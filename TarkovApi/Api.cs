using System.Diagnostics;
using System.Net.Http.Json;
using Tarkov.Dictionaries;

namespace Tarkov
{
    public class Api
    {
        // STATIC
        /// <summary>
        /// Prevent multiple instances of the API. Not really required but nice to have.
        /// </summary>
        private static Api instance = null;
        public static Api GetApi()
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
        private async Task<String> MakeCallAsync(string call, string searchType, string searchKey, string properties)
        {
            Dictionary<string, string> data = new Dictionary<string, string>()
            {
                {"query", "{"+call+"("+searchType+": \""+searchKey+"\") { "+properties+" }}"}
            };

            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PostAsJsonAsync("https://api.tarkov.dev/graphql", data);
                string responseContent = await httpResponse.Content.ReadAsStringAsync();

                return responseContent;
            }
        }

        public async Task GetTasks(string faction)
        {
            string result = await MakeCallAsync("tasks", "faction", faction.ToUpper(), ObjectProperties.Task);
        }
    }
}