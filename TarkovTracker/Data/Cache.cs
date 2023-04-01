using Tarkov;
using Tarkov.Dictionaries;
using Tarkov.Entities;
using Tarkov.Enums;
using static System.Collections.Specialized.BitVector32;

namespace TarkovTracker.Data
{
    public static class Cache
    {
        public static Dictionary<string, Quest> AllQuests { get; set; }
		public static Dictionary<string, Craft> AllCrafts { get; set; }
		public static Dictionary<string, Craft> WorkbenchCrafts { get; set; }
		public static Dictionary<string, Craft> LavatoryCrafts { get; set; }
		public static Dictionary<string, Craft> MedCrafts { get; set; }
		public static Dictionary<string, Craft> IntelCrafts { get; set; }
		public static Dictionary<string, Craft> FoodCrafts { get; set; }

		public static List<Quest>? LoadedQuests { get; set; }

        public static async Task LoadCache()
		{
			AllQuests = new Dictionary<string, Quest>();
			AllCrafts = new Dictionary<string, Craft>();
			WorkbenchCrafts = new Dictionary<string, Craft>();
			LavatoryCrafts = new Dictionary<string, Craft>();
			MedCrafts = new Dictionary<string, Craft>();
			IntelCrafts = new Dictionary<string, Craft>();
			FoodCrafts = new Dictionary<string, Craft>();

			Api tarkov = Api.GetTarkov();
            Quest[] quests = await tarkov.GetTasksAsync(false);
            foreach (var quest in quests) AllQuests.Add(quest.Id, quest);

            Craft[] crafts = await tarkov.GetCraftsAsync();
            foreach (var craft in crafts)
            {
                AllCrafts.Add(craft.Id, craft);

				if (craft.Station.Id.Equals(HideoutStations.StationIds.GetValueOrDefault(StationType.WORKBENCH))) WorkbenchCrafts.Add(craft.Id, craft);
				else if (craft.Station.Id.Equals(HideoutStations.StationIds.GetValueOrDefault(StationType.LAVATORY))) LavatoryCrafts.Add(craft.Id, craft);
				else if (craft.Station.Id.Equals(HideoutStations.StationIds.GetValueOrDefault(StationType.MEDSTATION))) MedCrafts.Add(craft.Id, craft);
				else if (craft.Station.Id.Equals(HideoutStations.StationIds.GetValueOrDefault(StationType.INTELLIGENCE))) IntelCrafts.Add(craft.Id, craft);
				else if (craft.Station.Id.Equals(HideoutStations.StationIds.GetValueOrDefault(StationType.NUTRITION))) FoodCrafts.Add(craft.Id, craft);
			}
        }
    }
}
