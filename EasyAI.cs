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
            bool targetEmpty = false;
            bool[] takenSpaces = new bool[9];
            char targetSpace = 'Z'; //set to Z so it does not correspond to a grid space should something go wrong
            while (targetEmpty == false)
            {
                targetSpace = Convert.ToChar(rand.Next(64, 73));
                targetEmpty = gameBoard.IsGridSpaceEmpty(targetSpace);
            }
            gameBoard.SetGridSpace(targetSpace, 'O'); 
        }
    }
}
