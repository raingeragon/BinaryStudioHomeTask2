using System.Collections.Generic;
using AnimalTypes;
using System.Linq;

namespace Repository
{
	public class AnimalRepository : IRepository
	{
		private List<Animal> animals = new List<Animal>();

		public void Add(Animal animal)
		{
			animals.Add(animal);
		}

		public Animal Get(string name)
		{
			return animals.FirstOrDefault(n => n.name == name);
		}
		public void Remove(Animal animal)
		{
			animals.Remove(animal);
		}
		public IEnumerable<Animal> AllAnimals()
		{
			return animals.AsReadOnly();
		}
	}
}
