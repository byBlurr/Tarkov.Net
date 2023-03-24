using Newtonsoft.Json;
using System.Net.Http.Json;
using Tarkov.Dictionaries;
using Tarkov.Entities;

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
    }
}