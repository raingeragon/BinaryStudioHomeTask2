namespace Controller.Commands
{
	class CommandInvoker
	{
		private ICommand command;

		public void SetCommand(ICommand command)
		{
			this.command = command;
		}
		public void Run()
		{
			command?.Execute();
		}
	}
}
