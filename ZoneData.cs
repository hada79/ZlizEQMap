using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace ZlizEQMap
{
	public class ZoneData
	{
		public ZoneData()
		{
			ConnectedZones = new List<ZoneData>();
		}

		public string ShortName { get; set; }
		public string FullName { get; set; }
		/// <summary>
		/// The X, Y coordinate on the map image where EQ /loc (0, 0) is
		/// </summary>
		public Point ZeroLocation { get; set; }
		/// <summary>
		/// The total amount of coords on the Y-axis (vertical) of the map iamge
		/// </summary>
		public int TotalY { get; set; }
		/// <summary>
		/// The total amount of coords on the X-axis (horizontal) of the map iamge
		/// </summary>
		public int TotalX { get; set; }
		public List<string> Legend { get; set; }
		public string Continent { get; set; }
		public string ContinentSortOrderString { get; set; }

		public int ContinentSortOrder
		{
			get { return Convert.ToInt32(ContinentSortOrderString); }
		}

		public List<ZoneData> ConnectedZones { get; set; }
		public int SubMapIndex { get; set; }
		public string SubMapDescription { get; set; }

		public string ImageFilePath
		{
			get
			{
				string jpgMap = GetImageFilePath("jpg");

				if (File.Exists(jpgMap))
					return jpgMap;

				string gifMap = GetImageFilePath("gif");

				if (File.Exists(gifMap))
					return gifMap;

				string pngMap = GetImageFilePath("png");

				if (File.Exists(pngMap))
					return pngMap;

				throw new Exception(String.Format("Map file matching zone '{0}' not found", this.ShortName));
			}
		}

		private string GetImageFilePath(string extension)
		{
			return Path.Combine(Path.Combine(Paths.ZoneMapsPath, ContinentSortOrderString + Continent), String.Format("{0}{1}.{2}", this.ShortName, this.SubMapIndex.ToString(), extension));
		}

		public override string ToString()
		{
			return String.Format("{0} @ {1}", FullName, Continent);
		}
	}
}
