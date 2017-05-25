using System;
using System.Linq;
using Repository;
using Controller.Commands;
using System.Threading;
using AnimalTypes;

namespace Controller
{
	public class Zoo
	{
		private AnimalController counter;

		public IRepository animals { get; private set; }
		private void GameOver(object sender)
		{
			Console.WriteLine("Game over! See you next time");
			Thread.Sleep(3000);
			Environment.Exit(0);
		}

		public Zoo()
		{
			animals = new AnimalRepository();

		}

		public void Add(string name, string type)
		{
			if (animals.Get(name) == null)
			{
				animals.Add(AbstractFactory.GetAnimal(name, type));
				if (animals.AllAnimals().Count() == 1)
				{
					counter = new AnimalController(animals);
					counter.AllAreDeadEvent += GameOver;
				}
				Console.WriteLine(type + " named " + name + " was added");
			}
			else Console.WriteLine("You already have animal with this name");
		}

		public void Feed(string name)
		{
			if (animals.Get(name) == null)
				Console.WriteLine("Animal with this name doesnt exist");
			else
			{
				FeedCommand command = new FeedCommand(animals.Get(name));
				CommandInvoker invoker = new CommandInvoker();

				invoker.SetCommand(command);
				invoker.Run();
			}
		}

		public void Cure(string name)
		{
			if (animals.Get(name) == null)
				Console.WriteLine("Animal with this name doesnt exist");
			else
			{
				CureCommand command = new CureCommand(animals.Get(name));
				CommandInvoker invoker = new CommandInvoker();

				invoker.SetCommand(command);
				invoker.Run();
			}
		}

		public void Remove(string name)
		{
			var animal = animals.Get(name);
			if (animal == null)
				Console.WriteLine("Animal with this name doesnt exist");
			else
				if (animal != null && animal.state == State.Dead)
				{
					Console.WriteLine(name + "was removed from the zoo");
					animals.Remove(animal);
				}
			else
				Console.WriteLine("This animal is alive. You can't remove it");
		}
	}
}

