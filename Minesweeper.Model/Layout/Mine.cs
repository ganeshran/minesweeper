using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Minesweeper.Interfaces.Layout;
using Minesweeper.Interfaces.State;

namespace Minesweeper.Model.Layout
{
    class Cell: ICell
    {
        public MineState State { get; set; }
        public MineUserState DisplayState { get; set; }
        private int SurroundingMines { get; set; }

        public Cell(char mineChar)
        {
            switch (mineChar)
            {
                case 'x':
                    State = MineState.NonMine;
                    break;
                default:
                    State = MineState.Mine;
                    break;
            }
        }



        public override string ToString()
        {
            switch (DisplayState)
            {
                case MineUserState.Hidden:
                    return "x";
                    break;
                case MineUserState.OpenNoMine:
                    return "0";
                    break;
                    case MineUserState.OpenMine:
                    return "m";
                    break;
                case MineUserState.Flagged:
                    return "f";
                    break;
                default:
                    return "x";

            }
        }

        public bool ApplyMove(char input)
        {
            if (input == 'o')
            {
                if (State == MineState.Mine)
                {
                    DisplayState = MineUserState.OpenMine;
                    return false;
                }
                else
                {
                    DisplayState = MineUserState.OpenNoMine;
                    return true;
                }
            }
            DisplayState = MineUserState.Flagged;
            return true;
        }

        public bool CheckOpen()
        {
            return this.DisplayState != MineUserState.Hidden;
        }
    }
}
