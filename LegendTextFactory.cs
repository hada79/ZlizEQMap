using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZlizEQMap
{
	public static class LegendTextFactory
	{
		public static string GetLegendText(ZoneData zoneData)
		{
			List<string> numbers = new List<string>();
			List<string> bullets = new List<string>();

			int fontSize = Settings.LegendFontSize;

			if (fontSize < 1 || fontSize > 50)
				fontSize = 10;

			foreach (string line in zoneData.Legend)
			{
				if (!line.StartsWith("*"))
					numbers.Add(line);
				else
					bullets.Add(line);
			}

			StringBuilder text = new StringBuilder();

			text.Append(String.Format("<html><body><head><meta charset=\"UTF-8\"><style type=\"text/css\">	body {{ font-family: tahoma; font-size: {0}pt }}	</style></head><ol>", fontSize));

			foreach (string line in numbers)
			{
				text.Append(String.Format("<li>{0}</li>", line));
			}

			text.Append("</ol>");

			if (bullets.Count > 0)
			{
				text.Append("<ul>");

				foreach (string line in bullets)
				{
					text.Append(String.Format("<li>{0}</li>", line.Substring(1)));
				}

				text.Append("</ul>");
			}

			text.Append("</body></html>");

			return text.ToString();
		}
	}
}
