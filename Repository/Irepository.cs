using System.Collections.Generic;
using AnimalTypes;
using System.Linq;
using System;

namespace Repository
{
	public interface IRepository
	{
		void Add(Animal animal);
		Animal Get(string name);
		void Remove(Animal animal);
		IEnumerable<Animal> AllAnimals();


		IEnumerable<IGrouping<string, Animal>> Test1();
		IEnumerable<Animal> Test2(string state);
		IEnumerable<Animal> Test3();
		Animal Test4(string name);
		IEnumerable<string> Test5();
		IEnumerable<Animal> Test6();
		IEnumerable<Tuple<string, int>> Test7();
		IEnumerable<Animal> Test8();
		IEnumerable<Animal> Test9();
		double Test10();
	}
}
