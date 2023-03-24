using Newtonsoft.Json;
using Tarkov.Entities;
using Tarkov.Enums;

namespace Tarkov.Entities
{
    public class Item
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("normalizedName")]
        public string NormalizedName { get; private set; }

        [JsonProperty("shortName")]
        public string ShortName { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("basePrice")]
        public int BasePrice { get; private set; }

        [JsonProperty("updated")]
        public string Updated { get; private set; }

        [JsonProperty("width")]
        public int Width { get; private set; }

        [JsonProperty("height")]
        public int Height { get; private set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; private set; }

        [JsonProperty("iconLink")]
        public string IconLink { get; private set; }

        [JsonProperty("gridImageLink")]
        public string GridImageLink { get; private set; }

        [JsonProperty("baseImageLink")]
        public string BaseImageLink { get; private set; }

        [JsonProperty("inspectImageLink")]
        public string InspectImageLink { get; private set; }

        [JsonProperty("image512pxLink")]
        public string Image512pxLink { get; private set; }

        [JsonProperty("image8xLink")]
        public string Image8xLink { get; private set; }

        [JsonProperty("wikiLink")]
        public string WikiLink { get; private set; }

        [JsonProperty("types")]
        public ItemType[] Types { get; private set; }
        
        [JsonProperty("avg24hPrice")]
        public int Avg24hPrice { get; private set; }

        //[JsonProperty("properties")]
        //public ItemProperties Properties { get; private set; }

        [JsonProperty("conflictingItems")]
        public Item[] ConflictingItems { get; private set; }

        [JsonProperty("conflictingSlotIds")]
        public String[] ConflictingSlotIds { get; private set; }

        [JsonProperty("accuracyModifier")]
        public float AccuracyModifier { get; private set; }

        [JsonProperty("recoilModifier")]
        public float RecoilModifier { get; private set; }

        [JsonProperty("ergonomicsModifier")]
        public float ErgonomicsModifier { get; private set; }

        [JsonProperty("hasGrid")]
        public bool HasGrid { get; private set; }

        [JsonProperty("blocksHeadphones")]
        public bool BlocksHeadphones { get; private set; }

        [JsonProperty("link")]
        public string Link { get; private set; }

        [JsonProperty("lastLowPrice")]
        public int LastLowPrice { get; private set; }

        [JsonProperty("changeLast48h")]
        public float ChangeLast48h { get; private set; }

        [JsonProperty("changeLast48hPercent")]
        public float ChangeLast48hPercent { get; private set; }

        [JsonProperty("low24hPrice")]
        public int Low24hPrice { get; private set; }

        [JsonProperty("high24hPrice")]
        public int High24hPrice { get; private set; }

        [JsonProperty("lastOfferCount")]
        public int LastOfferCount { get; private set; }

        [JsonProperty("sellFor")]
        public ItemPrice[] SellFor { get; private set; }

        [JsonProperty("buyFor")]
        public ItemPrice[] BuyFor { get; private set; }

        [JsonProperty("containsItems")]
        public ContainedItem[] ContainsItems { get; private set; }

        [JsonProperty("category")]
        public ItemCategory Category { get; private set; }

        [JsonProperty("categories")]
        public ItemCategory[] Categories { get; private set; }

        [JsonProperty("bsgCategoryId")]
        public string BsgCategoryId { get; private set; }

        [JsonProperty("handbookCategories")]
        public ItemCategory[] HandbookCategories { get; private set; }

        [JsonProperty("weight")]
        public float Weight { get; private set; }

        [JsonProperty("velocity")]
        public float Velocity { get; private set; }

        [JsonProperty("loudness")]
        public int Loudness { get; private set; }

        [JsonProperty("usedInTasks")]
        public Task[] UsedInTasks { get; private set; }

        [JsonProperty("receivedFromTasks")]
        public Task[] ReceivedFromTasks { get; private set; }

        [JsonProperty("bartersFor")]
        public Barter[] BartersFor { get; private set; }

        [JsonProperty("bartersUsing")]
        public Barter[] BartersUsing { get; private set; }

        [JsonProperty("craftsFor")]
        public Craft[] CraftsFor { get; private set; }

        [JsonProperty("craftsUsing")]
        public Craft[] CraftsUsing { get; private set; }

        [JsonProperty("historicalPrices")]
        public HistoricalPricePoint[] HistoricalPrices { get; private set; }
    }
}
