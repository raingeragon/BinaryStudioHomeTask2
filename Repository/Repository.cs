using System.Collections.Generic;
using AnimalTypes;
using System.Linq;
using System;

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

		public IEnumerable<IGrouping<string, Animal>> Test1()
		{
			return from n in animals
				   group n by n.type;
		}//done
		public IEnumerable<Animal> Test2(string state)
		{
			if (animals.Count() != 0)
			return from n in animals
				   where n.state.ToString().ToLower() == state.ToLower()
				   select n;
			return null;
		}//done
		public IEnumerable<Animal> Test3()
		{
			return from n in animals
				   where n.type == "Tiger"
				   where n.state == State.Sick
				   select n;
		}//done
		public Animal Test4(string name)
		{
			if (animals.Count() != 0)
				return (from n in animals
						where n.type == "elephant"
						where n.name == name
						select n).FirstOrDefault();
			return null;


		}//done
		public IEnumerable<string> Test5()
		{
			return from n in animals
				   where n.state == State.Hungry
				   select n.name;
		}//done
		public IEnumerable<Animal> Test6()
		{
			return animals
				.GroupBy(t => t.type)
				.Select(f => (f
				.OrderByDescending(x => x.health))
				.First());

		}//done
		public IEnumerable<Tuple<string, int>> Test7()
		{
			return animals
				.GroupBy(t => t.type)
				.Select(g => Tuple
				.Create<string, int>
				(g.Key, g.Where(a => a.state == State.Dead)
				.Count()));
		}//done
		public IEnumerable<Animal> Test8()
		{
			return from n in animals
				   where n.type == "wolf" || n.type == "bear"
				   where n.health > 3
				   select n;
		}//done
		public IEnumerable<Animal> Test9()
		{
			return ((from n in animals
					 orderby n.health
					 select n).Take(1).
						Concat
						((from n in animals
						 orderby n.health descending
						 select n).Take(1)));

		}//done
		public double Test10()
		{
			if (animals.Count() != 0)
				return (from n in animals
						select n.health).Average();
			return 0;
		}//done
	}
}
