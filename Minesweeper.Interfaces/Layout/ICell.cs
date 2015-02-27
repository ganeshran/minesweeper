using Minesweeper.Interfaces.State;

namespace Minesweeper.Interfaces.Layout
{
    public interface ICell
    {
        MineState State { get; set; }

        MineUserState DisplayState { get; set; }

        string ToString();

        bool ApplyMove(char input);

        bool CheckOpen();
    }
}
