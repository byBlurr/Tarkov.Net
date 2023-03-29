using Tarkov;
using Tarkov.Entities;

namespace TarkovTracker.Data
{
    public static class Cache
    {
        public static Dictionary<string, Quest> AllQuests { get; set; }

        public static List<Quest>? LoadedQuests { get; set; }

        public static async Task LoadCache()
        {
            Api tarkov = Api.GetTarkov();
            Quest[] quests = await tarkov.GetTasksAsync(false);
            foreach (var quest in quests) AllQuests.Add(quest.Id, quest);
        }
    }
}
