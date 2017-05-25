using AnimalTypes;
using AnimalTypes.Animals;
namespace Controller
{
	public static class AbstractFactory
	{
		public static Animal GetAnimal(string name, string type)
		{
			switch (type.ToLower())
			{
				case "wolf":
					return new Wolf(name);
				case "lion":
					return new Lion(name);
				case "elephant":
					return new Elephant(name);
				case "fox":
					return new Fox(name);
				case "tiger":
					return new Tiger(name);
				case "bear":
					return new Bear(name);
				default:
					return null;
					
			}
		}
	}
}