using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeAi
{
    class BasicAI
    {
        public virtual void TakeTurn(Board gameBoard)
        {
            Random rand = new Random();
            bool targetEmpty = false;
            bool[] availableSpaces = new bool[9];
            int increment = 0;
            char targetSpace = '0';
            for (int i = 0; i<9; i++)
            {
                availableSpaces[i] = true;
            }
            for (int i = 0; i<3;i++)
            {
                for (int j = 0; j<3; j++)
                {
                    if (gameBoard.grid[i,j].GetSpace() == 'X' || gameBoard.grid[i, j].GetSpace() == 'O')
                    {
                        availableSpaces[increment]=false;
                    }
                    increment++;
                }
            }
            while (targetEmpty == false)
            {
                targetSpace = Convert.ToChar(rand.Next(49,57));
                targetEmpty = gameBoard.IsGridSpaceEmpty(targetSpace);
            }
            gameBoard.SetGridSpace(targetSpace, 'O'); 
        }
    }
}
