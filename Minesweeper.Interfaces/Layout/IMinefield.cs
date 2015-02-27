using System.Collections.Generic;
using Minesweeper.Interfaces.State;

namespace Minesweeper.Interfaces.Layout
{
    public interface IMinefield
    {
        GameState GameState { get; set; }
        ICell[,] Mines { get; set; }
        void InitializeMinefield(string mineLayout);
        bool IsGameOver { get; set; }
        void Move(string moveOption);
    }
}
