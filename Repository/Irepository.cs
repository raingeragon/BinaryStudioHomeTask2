using System.Collections.Generic;
using AnimalTypes;

namespace Repository
{
	public interface IRepository
	{
		void Add(Animal animal);
		Animal Get(string name);
		void Remove(Animal animal);
		IEnumerable<Animal> AllAnimals();
	}
}
