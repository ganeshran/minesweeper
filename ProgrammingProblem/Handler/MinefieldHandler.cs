using System;
using Minesweeper.Interfaces.Handler;

namespace Minesweeper.Application.Handler
{
    class MinefieldHandler: IMinefieldHandler
    {
        public string RequestUserInput()
        {
            Console.WriteLine("Please Enter Mine Layout in the form of comma seperated mine values");
           // var mineLayout = Console.ReadLine();
            //return mineLayout;
            //Hardcoding output for now
            return "xxm,xmx,xxx";
        }

        public string GetMoveOption()
        {
            Console.WriteLine("Please enter the option in form of o or f followed by coordinates");
            var option = Console.ReadLine();
            return option;
        }
    }
}
