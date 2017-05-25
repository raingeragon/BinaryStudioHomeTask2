using System;
using Controller;

namespace ZOO
{
	public class UserInterface
	{
		const string types = "(These types are possible: Bear, Elephant, Fox, Lion, Tiger, Wolf)\n\n";
		const string help = "\nTo add animal write \"add [animal name] [animal type]\" \n\n" +
			 types + 
			"To feed animal write \"feed [animal name]\" \n\n" +
			"To cure animal write \"cure [animal name]\" \n\n" +
			"To remove animal from the zoo write \"remove [animal name]\" \n\n" +
			"To view all animals write \"all\" \n\n" +
			"To see help again write \"help\" \n\n" +
			"To clearscreen write \"clear\" \n\n" +
			"To exit type exit \n";

		Zoo zoo;
		public UserInterface(Zoo zoo)
		{
			this.zoo = zoo;
			Console.WriteLine("HELLO!");
			Console.WriteLine(help);
		}

		public bool Input()
		{
			string[] input = (Console.ReadLine()).Split(' ');

			switch (input[0].ToLower())
			{
				case "feed":
					zoo.Feed(input[1]);
					return true;
				case "cure":
					zoo.Cure(input[1]);
					return true;
				case "add":
					zoo.Add(input[1], input[2]);
					return true;
				case "remove":
					zoo.Remove(input[1]);
					return true;
				case "exit":
					return false;
				case "help":
					Console.WriteLine(help);
					return true;
				case "all":
					foreach (var x in zoo.animals.AllAnimals())
						Console.WriteLine("{0} {1} has {2} health and feels {3}", x.type, x.name, x.health, x.state);
					return true;
				case "clear":
					Console.Clear();
					return true;
				default:
					Console.WriteLine("That's not a valid command");
					return true;
			}

		}
	}
}
