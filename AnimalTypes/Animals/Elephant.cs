namespace AnimalTypes.Animals
{
	public class Elephant : Animal
	{
		public Elephant(string name) : base(name)
		{
			maxHealth = 3;
			health = maxHealth;
			type = "elephant";
		}
	}
}
