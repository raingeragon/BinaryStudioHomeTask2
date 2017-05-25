using System;
using Controller;
using ZOO;

namespace UI
{
	class UserInput
	{
		static void Main(string[] args)
		{
			Zoo zoo = new Zoo();
			UserInterface input = new UserInterface(zoo);

			bool flag = true;
			while (flag)
			{

				flag = input.Input();	
			}
			
		}
	}
}
