using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTypes
{
	public abstract class Animal
	{
		public string name { get; private set; }
		public int health { get; set; }
		public State state { get; set; }
		public int maxHealth { get; protected set; }
		public string type { get; protected set; }

		public Animal(string name)
		{
			this.name = name;
			state = State.Fed;
		}

		public void Feed()
		{
			if (state == State.Hugry)
				state = State.Fed;

		}
		public void Cure()
		{
			if (health < maxHealth && state != State.Dead)
				health++;
			if (state == State.Sick)
				state = State.Hugry;
		}
		public void NextState()
		{
			switch (state)
			{
				case State.Fed:
					state++;
					break;
				case State.Hugry:
					state++;
					break;
				case State.Sick:
					health--;
					if (health == 0)
						state++;

					break;
			}
		}
	}
	public enum State
	{
		Fed,
		Hugry,
		Sick,
		Dead
	}
}