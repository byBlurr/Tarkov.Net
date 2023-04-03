using Tarkov;
using Tarkov.Dictionaries;
using Tarkov.Entities;
using Tarkov.Enums;

namespace TarkovTracker.Data
{
    public static class Cache
    {
		public static bool Completed = false;
        public static Dictionary<string, Quest> AllQuests { get; set; }
		public static Dictionary<string, Craft> AllCrafts { get; set; }
		public static Dictionary<string, Craft> WorkbenchCrafts { get; set; }
		public static Dictionary<string, Craft> LavatoryCrafts { get; set; }
		public static Dictionary<string, Craft> MedCrafts { get; set; }
		public static Dictionary<string, Craft> IntelCrafts { get; set; }
		public static Dictionary<string, Craft> FoodCrafts { get; set; }

		public static int MetalFuelCost { get; set; } = 9999999;

		public static int PlasticFuelCost { get; set; } = 9999999;

        public static List<Quest>? LoadedQuests { get; set; }

        public static async Task LoadCache()
		{
			Completed = false;

			AllQuests = new Dictionary<string, Quest>();
			AllCrafts = new Dictionary<string, Craft>();
			WorkbenchCrafts = new Dictionary<string, Craft>();
			LavatoryCrafts = new Dictionary<string, Craft>();
			MedCrafts = new Dictionary<string, Craft>();
			IntelCrafts = new Dictionary<string, Craft>();
			FoodCrafts = new Dictionary<string, Craft>();

			Api tarkov = Api.GetTarkov();

			/*
			string[] calls =
			{
				"items (ids:[\"5d1b36a186f7742523398433\"\"5d1b371186f774253763a656\"]){"+ObjectProperties.Item+"}",
				"quests {"+ObjectProperties.Task+"}",
				"crafts {"+ObjectProperties.Craft+"}"
			};
			tarkov.
			*/

			var metal = await tarkov.GetItemAsync("5d1b36a186f7742523398433");
			var plastic = await tarkov.GetItemAsync("5d1b371186f774253763a656");

			if (metal != null)
			{
				MetalFuelCost = metal.BuyFor[0].PriceRUB;
				foreach (var s in metal.BuyFor) if (s.PriceRUB < MetalFuelCost) MetalFuelCost = s.PriceRUB;
			}
			if (plastic != null)
			{
				PlasticFuelCost = plastic.BuyFor[0].PriceRUB;
				foreach (var s in plastic.BuyFor) if (s.PriceRUB < PlasticFuelCost) PlasticFuelCost = s.PriceRUB;
			}

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

			Completed = true;
        }
    }
}
