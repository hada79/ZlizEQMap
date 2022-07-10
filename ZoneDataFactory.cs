using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ZlizEQMap
{
	public static class ZoneDataFactory
	{
		public static List<string> GetZoneDataSets()
		{
			List<string> zoneDataSets = new List<string>();

			foreach (string file in Directory.GetFiles(Paths.ZoneDataPath, "ZoneData-*.txt", SearchOption.TopDirectoryOnly))
			{
				string fileName = Path.GetFileNameWithoutExtension(file);
				zoneDataSets.Add(fileName.Substring(fileName.IndexOf('-') + 1));
			}

			return zoneDataSets;
		}

		public static ZoneData FetchByShortZoneName(List<ZoneData> zoneData, string zoneShortName)
		{
			return zoneData.FirstOrDefault(x => x.ShortName == zoneShortName && x.SubMapIndex == 1);
		}

		public static ZoneData FetchByFullZoneName(List<ZoneData> zoneData, string zoneFullName, int subMapIndex)
		{
			return zoneData.FirstOrDefault(x => x.FullName == zoneFullName && x.SubMapIndex == subMapIndex);
		}

		public static Dictionary<string, string> GetZoneData(string zoneDataSet)
		{
			Dictionary<string, string> zoneData = new Dictionary<string, string>();

			foreach (string line in File.ReadAllLines(Paths.GetZoneDataFilePath(zoneDataSet)))
			{
				if (!String.IsNullOrEmpty(line) && !line.StartsWith("//"))
				{
					string zoneShortName = line.Substring(0, line.IndexOf('='));
					string zoneFullName = line.Substring(line.IndexOf('=') + 1);

					zoneData.Add(zoneShortName, zoneFullName);
				}
			}

			return zoneData;
		}

		public static Dictionary<string, List<string>> GetZoneConnections()
		{
			Dictionary<string, List<string>> connections = new Dictionary<string, List<string>>();

			foreach (string line in File.ReadAllLines(Paths.ZoneConnectionsFilePath))
			{
				if (!String.IsNullOrEmpty(line) && !line.StartsWith("//"))
				{
					string zoneShortName = line.Substring(0, line.IndexOf('='));
					string connsString = line.Substring(line.IndexOf('=') + 1);

					List<string> conns = new List<string>();

					foreach (string con in connsString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
					{
						conns.Add(con);
					}

					connections.Add(zoneShortName, conns);
				}
			}

			return connections;
		}

		public static List<ZoneData> GetAllZones(string zoneDataSet)
		{
			Dictionary<string, string> zoneData = ZoneDataFactory.GetZoneData(zoneDataSet);

			List<ZoneData> zones = new List<ZoneData>();

			foreach (KeyValuePair<string, string> kvp in zoneData)
			{
				List<string> paths = GetZoneDataFilePaths(kvp.Key);

				foreach (string path in paths)
				{
					string[] lines = File.ReadAllLines(path);

					List<string> legend = new List<string>(lines);
					legend.RemoveAt(0);

					string[] items = lines[0].Split('|');

					string fileName = Path.GetFileNameWithoutExtension(path);

					ZoneData zone = new ZoneData()
					{
						ShortName = kvp.Key,
						FullName = kvp.Value,
						Continent = GetContinentName(path).Substring(2),
						ContinentSortOrderString = GetContinentName(path).Substring(0, 2),
						ZeroLocation = new Point(Convert.ToInt32(items[0]), Convert.ToInt32(items[1])),
						TotalX = Convert.ToInt32(items[2]),
						TotalY = Convert.ToInt32(items[3]),
						Legend = legend,
						SubMapIndex = Int32.Parse(fileName[fileName.Length - 1].ToString()),
						SubMapDescription = (items.Length == 5 ? items[4] : null)
					};

					zones.Add(zone);
				}
			}

			Dictionary<string, List<string>> connections = ZoneDataFactory.GetZoneConnections();

			foreach (ZoneData zone in zones)
			{
				List<string> zoneConnections = connections[zone.ShortName];

				foreach (string zoneConnection in zoneConnections)
				{
					ZoneData conn = zones.FirstOrDefault(x => x.ShortName == zoneConnection && x.SubMapIndex == 1);

					if (conn != null)
						zone.ConnectedZones.Add(conn);
				}
			}

			return zones;
		}

		private static List<string> GetZoneDataFilePaths(string zoneShortName)
		{
			List<string> paths = new List<string>();

			foreach (string path in Directory.GetFiles(Paths.ZoneDataPath, String.Format("{0}*.txt", zoneShortName), SearchOption.AllDirectories))
			{
				Regex regex = new Regex(String.Format(@"({0})[0-9]\.txt", zoneShortName));

				if (regex.IsMatch(path))
					paths.Add(path);
			}

			return paths;
		}

		private static string GetContinentName(string file)
		{
			FileInfo fi = new FileInfo(file);
			return fi.Directory.Name;
		}
	}
}
