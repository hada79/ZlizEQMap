using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ZlizEQMap
{
	public class LogFileParser
	{
		long seekPosition = 0;
		public string LogFilePath { get; set; }

		public LogFileParser(string logFilePath)
		{
			FileInfo fi = new FileInfo(logFilePath);
			long spoolBack = fi.Length > 5000 ? 5000 : fi.Length;
			seekPosition = new FileInfo(logFilePath).Length - spoolBack;
			LogFilePath = logFilePath;
		}

		public List<string> GetNewLines()
		{
			List<string> lines = new List<string>();

			try
			{
				using (FileStream fs = new FileStream(LogFilePath, FileMode.Open))
				{
					fs.Seek(seekPosition, SeekOrigin.Begin);

					using (TextReader tr = new StreamReader(fs))
					{
						string line = "";

						while ((line = tr.ReadLine()) != null)
						{
							if (line.Trim() != "")
								lines.Add(line);
						}

						seekPosition = fs.Position;
					}
				}
			}
			catch (Exception)
			{
			}

			return lines;
		}
	}
}
