using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeAi
{
    class EasyAI
    {
        public void TakeTurn(Board gameBoard)
        {
            Random rand = new Random();
            List<int> availableSpaces = new List<int>();
            int increment = 0;
            char targetSpaceChar; 
            for (int i = 0; i<3;i++)
            {
                for (int j = 0; j<3; j++)
                {
                    increment++;
                    if (gameBoard.grid[i,j] != 'X' && gameBoard.grid[i, j] != 'O')
                    {
                        availableSpaces.Add(increment);
                    }
                }
            }
            if (availableSpaces.Count != 1)
            {
                targetSpaceChar = Convert.ToChar((availableSpaces[rand.Next(1, availableSpaces.Count)] + 64));
                gameBoard.SetGridSpace(targetSpaceChar, 'O');
            }
            else
            {
                targetSpaceChar = Convert.ToChar((availableSpaces[0] + 64));
                gameBoard.SetGridSpace(targetSpaceChar, 'O');
            }
        }
    }
}
