using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeAi
{
    class Board
    {
        public BoardSpace[,] grid;
        public Board()
        {
            grid = new BoardSpace[3, 3];
            int increment = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j<3;j++)
                {
                    increment++;
                    grid[i, j] = new BoardSpace(increment);
                    grid[i, j].SetSpaceValue(Convert.ToChar(increment + 64));
                }
            }
            
        }
        public void DisplayBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0) {
                        Console.Write("| " + grid[i, j].GetSpace() + " | ");
                    }
                    else
                    {
                        Console.Write(grid[i, j].GetSpace() + " | ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void SetGridSpace(char space, char token)
        {
            switch (space)
            {
                case '1':
                    grid[0, 0].SetSpaceValue(token);
                    break;

                case '2':
                    grid[0, 1].SetSpaceValue(token);
                    break;

                case '3':
                    grid[0, 2].SetSpaceValue(token);
                    break;

                case '4':
                    grid[1, 0].SetSpaceValue(token);
                    break;

                case '5':
                    grid[1, 1].SetSpaceValue(token);
                    break;

                case '6':
                    grid[1, 2].SetSpaceValue(token);
                    break;

                case '7':
                    grid[2, 0].SetSpaceValue(token);
                    break;

                case '8':
                    grid[2, 1].SetSpaceValue(token);
                    break;

                case '9':
                    grid[2, 2].SetSpaceValue(token);
                    break;

            }
        }
        public bool IsGridSpaceEmpty(char space)
        {
            switch (space)
            {
                case '1':
                    if (grid[0, 0].GetSpace() == 'X' || grid[0, 0].GetSpace() == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case '2':
                    if (grid[0, 1].GetSpace() == 'X' || grid[0, 1].GetSpace() == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case '3':
                    if (grid[0, 2].GetSpace() == 'X' || grid[0, 2].GetSpace() == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case '4':
                    if (grid[1, 0].GetSpace() == 'X' || grid[1, 0].GetSpace() == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case '5':
                    if (grid[1, 1].GetSpace() == 'X' || grid[1,1].GetSpace() == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case '6':
                    if (grid[1, 2].GetSpace() == 'X' || grid[1,2].GetSpace() == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case '7':
                    if (grid[2, 0].GetSpace() == 'X' || grid[2,0].GetSpace() == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case '8':
                    if (grid[2, 1].GetSpace() == 'X' || grid[2,1].GetSpace() == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case '9':
                    if (grid[2, 2].GetSpace() == 'X' || grid[2,2].GetSpace() == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                default:
                    return false;

            }
        }
        public int CheckWin()
        {
            //TODO: code this for every possible win
            //player wins = 1, ai wins = 2, no one won = 0

            //Horizontal wins
            if (grid[0, 0].GetSpace() == grid[0, 1].GetSpace() && grid[0, 0].GetSpace() == grid[0, 2].GetSpace())
            {
                if (grid[0, 0].GetSpace() == 'X')
                {
                    return 1;
                }
                else if (grid[0, 0].GetSpace() == 'O')
                {
                    return 2;
                }
            }
            if (grid[1, 0].GetSpace() == grid[1, 1].GetSpace() && grid[1, 0].GetSpace() == grid[1, 2].GetSpace())
            {
                if (grid[1, 0].GetSpace() == 'X')
                {
                    return 1;
                }
                else if (grid[1, 0].GetSpace() == 'O')
                {
                    return 2;
                }
            }
            if (grid[2, 0].GetSpace() == grid[2, 1].GetSpace() && grid[2, 0].GetSpace() == grid[2, 2].GetSpace())
            {
                if (grid[2, 0].GetSpace() == 'X')
                {
                    return 1;
                }
                else if (grid[2, 0].GetSpace() == 'O')
                {
                    return 2;
                }
            }
            //Vertical column wins
            if (grid[0, 0].GetSpace() == grid[1, 0].GetSpace() && grid[0, 0].GetSpace() == grid[2, 0].GetSpace())
            {
                if (grid[0, 0].GetSpace() == 'X')
                {
                    return 1;
                }
                else if (grid[0, 0].GetSpace() == 'O')
                {
                    return 2;
                }
            }
            if (grid[0, 1].GetSpace() == grid[1, 1].GetSpace() && grid[0, 1].GetSpace() == grid[2, 1].GetSpace())
            {
                if (grid[0, 1].GetSpace() == 'X')
                {
                    return 1;
                }
                else if (grid[0, 1].GetSpace() == 'O')
                {
                    return 2;
                }
            }
            if (grid[0, 2].GetSpace() == grid[1, 2].GetSpace() && grid[0, 2].GetSpace() == grid[2, 2].GetSpace())
            {
                if (grid[0, 2].GetSpace() == 'X')
                {
                    return 1;
                }
                else if (grid[0, 2].GetSpace() == 'O')
                {
                    return 2;
                }
            }
            //Diagonal wins
            if (grid[0, 0].GetSpace() == grid[1, 1].GetSpace() && grid[0, 0].GetSpace() == grid[2, 2].GetSpace())
            {
                if (grid[0, 0].GetSpace() == 'X')
                {
                    return 1;
                }
                else if (grid[0, 0].GetSpace() == 'O')
                {
                    return 2;
                }
            }
            if (grid[0, 2].GetSpace() == grid[1, 1].GetSpace() && grid[0, 2].GetSpace() == grid[2, 0].GetSpace())
            {
                if (grid[0, 2].GetSpace() == 'X')
                {
                    return 1;
                }
                else if (grid[0, 2].GetSpace() == 'O')
                {
                    return 2;
                }
            }

            //No wins found, code will run to here, return 0 to indicate no win
            return 0;
        }
        public bool BoardFull()
        {
            int increment=0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j].GetSpace() == 'X' || grid[i,j].GetSpace() == 'O')
                    {
                        increment++;
                    }
                }
            }
            if (increment == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
