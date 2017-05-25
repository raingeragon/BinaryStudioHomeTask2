namespace AnimalTypes.Animals
{
	public class Bear : Animal
	{
		public Bear(string name) : base(name)
		{
			maxHealth = 6;
			health = maxHealth;
			type = "bear";
		}
	}
}
