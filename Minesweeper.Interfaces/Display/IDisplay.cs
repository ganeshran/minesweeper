using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Minesweeper.Interfaces.Layout;

namespace Minesweeper.Interfaces.Display
{
    public interface IDisplay
    {
        void DrawMineField(IMinefield mineField);
    }
}
