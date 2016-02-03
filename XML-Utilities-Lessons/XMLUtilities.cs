using System;
using System.IO;
using System.Xml.Serialization;

namespace XML_Utilities_Lessons
{
	public static class XmlUtilities
	{
		public static string FolderName;
		public static void SaveTest(Test test)
		{
			string fileAddress = TestAddress(test);

			while (File.Exists(fileAddress+".xml"))
			{
				fileAddress += "(new)";
			}
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Test));
			TextWriter writer = new StreamWriter(fileAddress+".xml");
			xmlSerializer.Serialize(writer,test);
			writer.Close();
		}

		private static string TestAddress(Test test)
		{
			return $"{FolderName}/{test.Number}. {test.Name}";
		}

		public static Test LoadTest(string address)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Test));
			TextReader rider = new StreamReader(FolderName+ "/" + address + ".xml");
			Test result = (Test)xmlSerializer.Deserialize(rider);
			rider.Close();
			return result;
		}
	}
}