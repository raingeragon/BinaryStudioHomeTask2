using AnimalTypes;

namespace Controller.Commands
{
	public class ChangeStateCommand : ICommand
	{
		Animal animal;

		public ChangeStateCommand(Animal animal)
		{
			this.animal = animal;
		}

		public void Execute()
		{
			animal?.NextState();
		}
	}
}
