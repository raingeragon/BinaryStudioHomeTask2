namespace AnimalTypes.Animals
{
	public class Lion : Animal
	{

		public Lion(string name) : base(name)
		{
			maxHealth = 5;
			health = maxHealth;
			type = "lion";
		}
	}
}
