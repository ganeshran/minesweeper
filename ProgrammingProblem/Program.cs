using System;
using Minesweeper.Application.Handler;
using Minesweeper.Interfaces.Handler;
using Minesweeper.Interfaces.State;
using Minesweeper.Model.Layout;
using Minesweeper.Application.Display;

namespace Minesweeper.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //These should be handled via DI layer
            var handler = new MinefieldHandler();
            var display = new MineDisplay();
            var userInput = handler.RequestUserInput();
            var minefield = new Minefield(userInput);
            display.DrawMineField(minefield);

            while (!minefield.IsGameOver)
            {
                var userOption = handler.GetMoveOption();
                minefield.Move(userOption);
                display.DrawMineField(minefield);
                Console.WriteLine();
            }

            Console.WriteLine("Game Over".ToUpper());
            Console.WriteLine(minefield.GameState == GameState.Lost ? "You Lose".ToUpper() : "You Win".ToUpper());
            display.DrawMineField(minefield);

        }
    }
}
