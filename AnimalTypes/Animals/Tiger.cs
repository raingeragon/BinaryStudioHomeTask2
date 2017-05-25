namespace AnimalTypes.Animals
{
	public class Tiger : Animal
	{
		public Tiger(string name) : base(name)
		{
			maxHealth = 4;
			health = maxHealth;
			type = "tiger";
		}
	}
}
