using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;
using System.Runtime.Serialization.Formatters.Binary;
using Tarkov.Dictionaries;
using Tarkov.Entities;
using Tarkov.Enums;

namespace Tarkov
{
    public class Api
    {
        // STATIC
        /// <summary>
        /// Prevent multiple instances of the API. Not really required but nice to have.
        /// </summary>
        private static Api instance = null;
        public static Api GetTarkov()
        {
            if (instance == null) instance = new Api();
            return instance;
        }

        // NON-STATIC

        private Api(){}

        /// <summary>
        /// Make a call to the Tarkov.dev API
        /// </summary>
        /// <param name="call">The data to retrieve.</param>
        /// <param name="searchType">How to search, aka ids.</param>
        /// <param name="searchKey">The search key for above.</param>
        /// <param name="properties">The properties to get back in the response.</param>
        /// <returns>Returns the response as a string.</returns>
        private async Task<TarkovResult> MakeCallAsync(string call, string properties, string searchType = "", string searchKey = "")
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(searchType) || string.IsNullOrEmpty(searchKey))
            {
                data.Add("query", "{" + call + " { " + properties + " }}");
            }
            else
            {
                data.Add("query", "{" + call + "(" + searchType + ": \"" + searchKey + "\") { " + properties + " }}");
            }

            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PostAsJsonAsync("https://api.tarkov.dev/graphql", data);
                string responseContent = await httpResponse.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<TarkovResult>(responseContent);
            }
        }

        public async Task<Data> CreateMassCallAsync(string[] calls)
        {
			Dictionary<string, string> data = new Dictionary<string, string>();
            string call = "{";
            foreach (string c in calls) call += c;
            call += "}";

			data.Add("query", call);

			using (var httpClient = new HttpClient())
			{
				var httpResponse = await httpClient.PostAsJsonAsync("https://api.tarkov.dev/graphql", data);
				string responseContent = await httpResponse.Content.ReadAsStringAsync();

				return JsonConvert.DeserializeObject<TarkovResult>(responseContent).Data;
			}
		}


        public TimeSpan GetTime()
        {
            // tarkov time = (real time * 7 % 24 hr) +3 hour
            long real = DateTime.UtcNow.TimeOfDay.Ticks;
            long russia = TimeSpan.TicksPerHour * 3;
            int tarkyRatio = 7;

            return TimeSpan.FromTicks(((real * tarkyRatio) % (TimeSpan.TicksPerHour * 24)) + russia);
        }

        public async Task<Status?> GetStatusAsync()
        {
            var result = await MakeCallAsync("status", ObjectProperties.Status);
            return result.Data.ServerStatus?.GeneralStatus;
        }

        public async Task<Item> GetItemAsync(string id)
        {
			var result = await MakeCallAsync($"item (id:\"{id}\")", ObjectProperties.Item);
            return result.Data.Item;
        }

		public async Task<Item[]> GetItemsAsync(string ids = "")
		{
            if (ids == "")
            {
                var result = await MakeCallAsync("items", ObjectProperties.Item);
                return result.Data.Items;
            }
            else
            {
				var result = await MakeCallAsync("items (ids:["+ids+"])", ObjectProperties.Item);
				return result.Data.Items;
			}
		}

		public async Task<Quest[]> GetTasksAsync(bool reduced = true, string faction = "ALL")
        {
            if (faction.Equals("ALL"))
            {
                if (reduced)
                {
                    var result = await MakeCallAsync("tasks", ObjectProperties.TaskReduced);
                    return result.Data.Tasks;
                }
                else
                {
                    var result = await MakeCallAsync("tasks", ObjectProperties.Task);
                    return result.Data.Tasks;
                }
            }
            else
            {
                if (reduced)
                {
                    var result = await MakeCallAsync("tasks", ObjectProperties.TaskReduced, "faction", faction.ToUpper());
                    return result.Data.Tasks;
                }
                else
                {
                    var result = await MakeCallAsync("tasks", ObjectProperties.Task, "faction", faction.ToUpper());
                    return result.Data.Tasks;
                }
            }
        }

        public async Task<Quest> GetTaskAsync(string id)
        {
            var result = await GetTasksAsync(false);
            if (result != null)
            {
                foreach (Quest quest in result)
                {
                    if (quest.Id.Equals(id)) return quest;
                }
            }
            Console.WriteLine("Can't find quest with id: " + id);
            return null;
        }

        public async Task<Craft[]> GetCraftsAsync(StationType station = StationType.ALL)
        {
			var result = await MakeCallAsync("crafts", ObjectProperties.Craft);
            if (station == StationType.ALL)
            {
                return result.Data.Crafts;
            }
            else
            {
                List<Craft> crafts = new List<Craft>();
                foreach (Craft craft in result.Data.Crafts)
                {
                   if (craft.Station.Id.Equals(HideoutStations.StationIds.GetValueOrDefault(station)))
                   {
                        crafts.Add(craft);
                   }
				}
                return crafts.ToArray();
			}
		}
    }
}