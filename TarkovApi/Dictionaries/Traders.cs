using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkov.Dictionaries
{
    public static class Traders
    {
        public static readonly Dictionary<string, string> TraderIds = new Dictionary<string, string>()
        {
            {"prapor", "54cb50c76803fa8b248b4571"},
            {"therapist", "54cb57776803fa99248b456e"},
            {"fence", "579dc571d53a0658a154fbec"},
            {"skier", "58330581ace78e27b8b10cee"},
            {"peacekeeper", "5935c25fb3acc3127c3d8cd9"},
            {"mechanic", "5a7c2eca46aef81a7ca2145d"},
            {"ragman", "5ac3b934156ae10c4430e83c"},
            {"jaeger", "5c0647fdd443bc2504c2d371"},
            {"lightkeeper", "638f541a29ffd1183d187f57"},
        };
        public static readonly Dictionary<string, string> TraderNames = new Dictionary<string, string>()
        {
            {"54cb50c76803fa8b248b4571", "prapor"},
            {"54cb57776803fa99248b456e", "therapist"},
            {"579dc571d53a0658a154fbec", "fence"},
            {"58330581ace78e27b8b10cee", "skier"},
            {"5935c25fb3acc3127c3d8cd9", "peacekeeper"},
            {"5a7c2eca46aef81a7ca2145d", "mechanic"},
            {"5ac3b934156ae10c4430e83c", "ragman"},
            {"5c0647fdd443bc2504c2d371", "jaeger"},
            {"638f541a29ffd1183d187f57", "lightkeeper"},
        };

        public static Dictionary<string, int> GetFreshTraders()
        {
            Dictionary<string, int> traders = new Dictionary<string, int>()
            {
                {TraderIds.GetValueOrDefault("prapor"), 1},
                {TraderIds.GetValueOrDefault("therapist"), 1},
                {TraderIds.GetValueOrDefault("fence"), 1},
                {TraderIds.GetValueOrDefault("skier"), 1},
                {TraderIds.GetValueOrDefault("peacekeeper"), 1},
                {TraderIds.GetValueOrDefault("mechanic"), 1},
                {TraderIds.GetValueOrDefault("ragman"), 1},
                {TraderIds.GetValueOrDefault("jaeger"), 1},
                {TraderIds.GetValueOrDefault("lightkeeper"), 0},
            };
            return traders;
        }
    }
}
