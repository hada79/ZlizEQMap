using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ZlizEQMap
{
	public static class Paths
	{
		private static string GetBaseApplicationPath()
		{
			string basePath = Application.StartupPath;

			if (UnitTestDetector.IsInUnitTest)
				basePath = @"c:\devdirectory";

			return basePath;
		}

		public static string GetZoneDataFilePath(string zoneDataSet)
		{
			return Path.Combine(ZoneDataPath, String.Format("ZoneData-{0}.txt", zoneDataSet));
		}

		public static string ZoneConnectionsFilePath
		{
			get
			{
				return Path.Combine(ZoneDataPath, "ZoneConnections.txt");
			}
		}

		public static string ZoneDataPath
		{
			get
			{
				string basePath = GetBaseApplicationPath();
				return Path.Combine(basePath, "ZoneData");
			}
		}

		public static string ZoneMapsPath
		{
			get
			{
				return Path.Combine(GetBaseApplicationPath(), "ZoneMaps");
			}
		}

		public static string SettingsFileDirectory
		{
			get
			{
				return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ZlizEQMap");
			}
		}

		public static string SettingsFilePath
		{
			get
			{
				return Path.Combine(SettingsFileDirectory, "ZlizEQMap.ini");
			}
		}
	}
}
