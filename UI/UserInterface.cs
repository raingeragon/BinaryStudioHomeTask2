using System;
using Controller;
using AnimalTypes;

namespace ZOO
{
	public class UserInterface
	{
		const string types = "(These types are possible: Bear, Elephant, Fox, Lion, Tiger, Wolf)\n\n";
		const string help = "\nTo add animal write \"add [animal name] [animal type]\" \n\n" +
			 types + 
			"To show information about animal write \"show [animal name]\" \n\n"+
			"To feed animal write \"feed [animal name]\" \n\n" +
			"To cure animal write \"cure [animal name]\" \n\n" +
			"To remove animal from the zoo write \"remove [animal name]\" \n\n" +
			"To view all animals write \"all\" \n\n" +
			"To see help again write \"help\" \n\n" +
			"To see help for task3 write \"taskhelp\" \n\n" +
			"To clear screen write \"clear\" \n\n" +
			"To exit type exit \n";
		const string taskhelp = "\n" +
			"To show all animals grouped by type write \"test 1\" \n\n" +
			"To show animals by their state write \"test 2 [state]\" \n\n" +
			"To show all sick tigers write \"test 3\" \n\n" +
			"To show elephant by its name write \"test 4 [name]\" \n\n" +
			"To show names of all hungry animals write \"test 5\" \n\n" +
			"To show the helthiest animal of each type write \"test 6\" \n\n" +
			"To show number of dead animals of each typ write \"test 7\" \n\n" +
			"To show all wolfs and bear that have more then 3 health write \"test 8\" \n\n" +
			"To show animals with min and max health write \"test 9\" \n\n" +
			"To show average health write \"test 10\" \n\n";
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
				case "show":
					var a = zoo.animals.Get(input[1]);
					Console.WriteLine("{0} {1} has {2} health and feels {3}", a.type, a.name, a.health, a.state);
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
				case "taskhelp":
					Console.WriteLine(taskhelp);
					return true;
				case "all":
					foreach (var b in zoo.animals.AllAnimals())
						Console.WriteLine("{0} {1} has {2} health and feels {3}", b.type, b.name, b.health, b.state);
					return true;
				case "clear":
					Console.Clear();
					return true;
				case "test":
					if (input.Length > 1)
					{
						switch (input[1])
						{
							case "1":
								foreach (var c in zoo.animals.Test1())
								{
									Console.WriteLine("{0}-type animals:", c.Key);
									foreach (Animal animal in c)
										Console.WriteLine("{0} {1} has {2} health and feels {3}", animal.type, animal.name, animal.health, animal.state);
									Console.WriteLine();
								}
								return true;
							case "2":
								if (input.Length == 3)
									if (zoo.animals.Test2(input[2]) != null)
										foreach (var d in zoo.animals.Test2(input[2]))
											Console.WriteLine("{0} {1} has {2} health and feels {3}", d.type, d.name, d.health, d.state);

								return true;
							case "3":
								foreach (var e in zoo.animals.Test3())
									Console.WriteLine("{0} {1} has {2} health and feels {3}", e.type, e.name, e.health, e.state);

								return true;
							case "4":
								if (input.Length == 3)
								{
									var f = zoo.animals.Test4(input[2]);
									if (f != null)
										Console.WriteLine("{0} {1} has {2} health and feels {3}", f.type, f.name, f.health, f.state);
								}
								return true;
							case "5":
								foreach (var g in zoo.animals.Test5())
								{
									Console.WriteLine(g);
								}
								return true;
							case "6":
								foreach (var k in zoo.animals.Test6())
								{
									Console.WriteLine("{0} {1} has {2} health and feels {3}", k.type, k.name, k.health, k.state);
								}
								return true;
							case "7":
								var corpses = zoo.animals.Test7();
								foreach (var x in corpses)
								{
									Console.WriteLine("{0}: {1} dead animals", x.Item1, x.Item2);
								}
								return true;
							case "8":
								foreach (var m in zoo.animals.Test8())
								{
									Console.WriteLine("{0} {1} has {2} health and feels {3}", m.type, m.name, m.health, m.state);
								}
								return true;
							case "9":
								foreach (var n in zoo.animals.Test9())
								{
									Console.WriteLine("{0} {1} has {2} health and feels {3}", n.type, n.name, n.health, n.state);
								}
								return true;
							case "10":
								Console.WriteLine(zoo.animals.Test10());
								return true;
							default:
								Console.WriteLine("That's not a valid command");
								return true;
						}
					}
					else return true;
				default:
					Console.WriteLine("That's not a valid command");
					return true;

			}

		}
	}
}
