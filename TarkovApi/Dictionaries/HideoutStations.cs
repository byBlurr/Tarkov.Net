using Tarkov.Enums;

namespace Tarkov.Dictionaries
{
	public static class HideoutStations
	{
		public static readonly Dictionary<StationType, string> StationIds = new Dictionary<StationType, string>()
		{
			{StationType.WORKBENCH, "5d484fda654e7600681d9315"},
			{StationType.INTELLIGENCE, "5d484fdf654e7600691aadf8"},
			{StationType.LAVATORY, "5d484fba654e7600691aadf7"},
			{StationType.NUTRITION, "5d484fd1654e76006732bf2e"},
			{StationType.MEDSTATION, "5d484fcd654e7668ec2ec322"},
		};
		public static readonly Dictionary<string, StationType> StationNames = new Dictionary<string, StationType>()
		{
			{"5d484fda654e7600681d9315", StationType.WORKBENCH},
			{"5d484fdf654e7600691aadf8", StationType.INTELLIGENCE},
			{"5d484fba654e7600691aadf7", StationType.LAVATORY},
			{"5d484fd1654e76006732bf2e", StationType.NUTRITION},
			{"5d484fcd654e7668ec2ec322", StationType.MEDSTATION},
		};
	}
}
