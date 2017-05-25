using AnimalTypes;

namespace Controller.Commands
{
	public class FeedCommand : ICommand
	{
		Animal animal;
		public FeedCommand (Animal animal)
		{
			this.animal = animal;
		}
		public void Execute()
		{
			animal.Feed();
		}
	}
}
