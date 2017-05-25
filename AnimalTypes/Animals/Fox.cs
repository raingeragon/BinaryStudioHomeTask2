namespace AnimalTypes.Animals
{
	public class Fox : Animal
	{
		public Fox(string name) : base(name)
		{
			maxHealth = 3;
			health = maxHealth;
			type = "fox";
		}
	}
}
