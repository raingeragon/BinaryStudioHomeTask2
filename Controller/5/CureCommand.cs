using AnimalTypes;
namespace Controller.Commands
{
	public class CureCommand : ICommand
	{
		Animal animal;

		public CureCommand(Animal animal)
		{
			this.animal = animal;
		}
		public void Execute()
		{
			animal.Cure();
		}
	}
}
