using System;
using System.Collections.Generic;
using Minesweeper.Interfaces.Layout;
using Minesweeper.Interfaces.State;

namespace Minesweeper.Model.Layout
{
    public class Minefield: IMinefield 
    {
        public bool IsGameOver { get; set; }
        public GameState GameState { get; set; }
        public ICell[,] Mines { get; set; }

        public Minefield(string mineLayout)
        {
            this.InitializeMinefield(mineLayout);
            IsGameOver = false;
            GameState = GameState.InProgress;
        }

        //This method expects the mineLayout to be a comma seperated string
        public void InitializeMinefield(string mineLayout)
        {
            if (CheckInputFormat(mineLayout))
            {
                var rows = mineLayout.Split(',');
                Mines = new ICell[rows.Length,rows.Length];
                for (int i = 0; i < rows.Length; i++)
                {
                    for (int j = 0; j < rows[i].Length; j++)
                    {
                        Mines[i, j] = new Cell(rows[i][j]);
                    }
                }
            }
            else
            {
                //Make this a custom exception
                throw new Exception();
            }
        }

        private bool CheckInputFormat(string mineLayout)
        {
            //Do the Layout checking here 
            // and if it doesn't check out then throw a custom exception
            return true;
        }

        private bool CheckMoveFormat(string moveOption)
        {
            //Do the format checking
            return true;
        }

        private bool CheckAllMinesOpen()
        {
            for(int i=0;i<=Mines.GetUpperBound(0);i++)
            {
                for (int j = 0; j <= Mines.GetUpperBound(1); j++)
                {
                    if (!Mines[i, j].CheckOpen())
                        return false;
                }
            }
            return true;
        }


        public void Move(string moveOption)
        {
            if (CheckMoveFormat(moveOption))
            {
                var move = moveOption[0];
                var coordinates = moveOption.Substring(2, 3);
                int i = int.Parse(coordinates[0].ToString());
                int j = int.Parse(coordinates[1].ToString());
                int numOfSurroundingMines = this.GetSurroundingMines(i, j);
                IsGameOver = !Mines[i,j].ApplyMove(move);
                if(IsGameOver )
                    GameState = GameState.Lost;
            }
            else
            {
                //Throw Custom exception
                throw  new Exception();
            }

            if (this.CheckAllMinesOpen())
            {
                GameState = GameState.Won;
                IsGameOver = true;
            }

        }

        private int GetSurroundingMines(int i, int j)
        {
            return 0;
        }
    }
}
