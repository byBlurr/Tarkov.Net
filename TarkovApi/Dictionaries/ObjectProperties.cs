namespace Tarkov.Dictionaries
{
    public class ObjectProperties
    {
        // Starting off only getting id for objects, adding more as needed...

        public static readonly string Task = "id tarkovDataId name normalizedName trader { id } map { id } experience wikiLink minPlayerLevel taskRequirements { task { id name } } traderRequirements { id value } objectives { id type description maps { id } optional } startRewards { items { item { id } } } finishRewards { items { item { id } } } failConditions { id } failureOutcome { items { item { id } } } restartable factionName neededKeys { keys { id } } kappaRequired lightkeeperRequired descriptionMessageId startMessageId successMessageId failMessageId";
        public static readonly string TaskReduced = "id name minPlayerLevel taskRequirements { task { id name } } traderRequirements { id value }";

    }
}
