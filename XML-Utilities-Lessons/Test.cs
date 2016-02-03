using System;
namespace XML_Utilities_Lessons
{
	[Serializable]
    public class Test
	{
		public int Number;
		public string Name;
		public int TimeInMinutes;
		public Qustion[] Qustions;

		public Test()
		{
		}

		public Test(int number, string name, int timeInMinutes, Qustion[] qustions)
		{
			TimeInMinutes = timeInMinutes;
			Number = number;
			Name = name;
			Qustions = qustions;
		}

	}
}
