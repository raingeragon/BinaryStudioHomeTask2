namespace AnimalTypes.Animals
{
	public class Wolf : Animal
	{
		public Wolf(string name) : base(name)
		{
			maxHealth = 4;
			health = maxHealth;
			type = "wolf";
		}
	}
}
