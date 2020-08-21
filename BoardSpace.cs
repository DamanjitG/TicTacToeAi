using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeAi
{
    class BoardSpace
    {
        char spaceTag;
        char spaceValue;
        public BoardSpace(int whichSpace)
        {
            spaceTag = Convert.ToChar(whichSpace+48);
        }
        public int GetSpaceTag()
        {
            return spaceTag;
        }
        public void SetSpaceValue(char newValue)
        {
            spaceValue = newValue;
        }
        public char GetSpace()
        {
            if (spaceValue != 'X' && spaceValue != 'O')
            {
                return spaceTag;
            }
            else
            {
                return spaceValue;
            }
            
        }
    }
}
