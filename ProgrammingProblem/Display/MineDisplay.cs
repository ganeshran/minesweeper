using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Minesweeper.Interfaces.Display;
using Minesweeper.Interfaces.Layout;

namespace Minesweeper.Application.Display
{
    class MineDisplay: IDisplay 
    {
        public void DrawMineField(IMinefield mineField)
        {
            var rows = mineField.Mines.GetUpperBound(0);
            var columns = mineField.Mines.GetUpperBound(1);
            for (int i = 0; i <= rows; i++)
            {
                for(int j=0; j <= columns;j++)
                    Console.Write(mineField.Mines[i,j]);
                Console.Write("\n");
            }
        }
    }
}
