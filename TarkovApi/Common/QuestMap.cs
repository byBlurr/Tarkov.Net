using System.Diagnostics;
using Tarkov.Entities;

namespace Tarkov.Common
{
    public static class QuestMap
    {
        
        public static List<RQuest> GetQuestMap(Quest[] quests, List<string> completed)
        {
            List<RQuest> map = new List<RQuest>();

            if (quests != null)
            {
                foreach (Quest quest in quests)
                {
                    RQuest q = new RQuest(quest.MinPlayerLevel);
                    q.Name = quest.Name;
                    q.Id = quest.Id;

                    if (quest.TaskRequirements != null)
                    {
                        foreach (var requirement in quest.TaskRequirements)
                        {
                            if (requirement != null && requirement.Task != null && requirement.Task.Id != null)
                            {
                                if (completed != null)
                                {
                                    if (completed.Contains(requirement.Task.Id))
                                    {
                                        q.RequiredQuests.Add(requirement.Task.Id, true);
                                    } else q.RequiredQuests.Add(requirement.Task.Id, false);
                                } else q.RequiredQuests.Add(requirement.Task.Id, false);
                            }
                        }
                    }

                    map.Add(q);
                }
            }

            return map;
        }
    }

    public class RQuest // NEEDS PROPER NAMEs
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public Dictionary<string, bool> RequiredQuests { get; set; }
        public int MinLevel { get; }

        public RQuest(int minLevel)
        {
            MinLevel = minLevel;
            RequiredQuests = new Dictionary<string, bool>();
        }

        public bool IsUnlocked(int level)
        {
            if (level >= MinLevel)
            {
                return (!RequiredQuests.ContainsValue(false));
            }

            return false;
        }
    }
}
