using System;
using System.Linq;
using System.Threading;
using Repository;
using AnimalTypes;
using Controller.Commands;


namespace Controller
{
	class AnimalController
	{
		private const int delay = 50000;
		private Timer timer;
		private IRepository animals;

		public AnimalController(IRepository animals)
		{
			this.animals = animals;
			timer = new Timer(Round, null, 0, delay);
		}
		private void Round(object state)
		{

			CommandInvoker invoker = new CommandInvoker();
			ICommand command = new ChangeStateCommand(RandomAnimal());

			invoker.SetCommand(command);
			invoker.Run();

			if ((animals.AllAnimals().Where(n => n.state != State.Dead).Count() == 0))
			{
				timer.Change(Timeout.Infinite, 0);
				AllAreDeadEvent?.Invoke(this);
			}
		}
		private Animal RandomAnimal()
		{
			if (animals.AllAnimals().Count() == 0)
			{
				return null;
			}
			int rnum = new Random().Next(0, animals.AllAnimals().Count());
			return animals.AllAnimals().ToList()[rnum];
		}
		public event AllAreDeadHandler AllAreDeadEvent;
	}

	public delegate void AllAreDeadHandler(object sender);
}
