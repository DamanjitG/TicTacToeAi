﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeAi
{
    class Board
    {
        public char[,] grid = new char[3,3];
        public Board()
        {
            int increment = 65;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = Convert.ToChar(increment);
                    increment++;
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
                        Console.Write("| " + grid[i, j] + " | ");
                    }
                    else
                    {
                        Console.Write(grid[i, j] + " | ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void SetGridSpace(char space, char token)
        {
            switch (space)
            {
                case 'A':
                    grid[0, 0] = token;
                    break;

                case 'B':
                    grid[0, 1] = token;
                    break;

                case 'C':
                    grid[0, 2] = token;
                    break;

                case 'D':
                    grid[1, 0] = token;
                    break;

                case 'E':
                    grid[1, 1] = token;
                    break;

                case 'F':
                    grid[1, 2] = token;
                    break;

                case 'G':
                    grid[2, 0] = token;
                    break;

                case 'H':
                    grid[2, 1] = token;
                    break;

                case 'I':
                    grid[2, 2] = token;
                    break;

            }
        }
        public bool IsGridSpaceEmpty(char space)
        {
            switch (space)
            {
                case 'A':
                    if (grid[0, 0] == 'X' || grid[0, 0]== 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case 'B':
                    if (grid[0, 1] == 'X' || grid[0, 0] == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case 'C':
                    if (grid[0, 2] == 'X' || grid[0, 0] == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case 'D':
                    if (grid[1, 0] == 'X' || grid[0, 0] == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case 'E':
                    if (grid[1, 1] == 'X' || grid[0, 0] == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case 'F':
                    if (grid[1, 2] == 'X' || grid[0, 0] == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case 'G':
                    if (grid[2, 0] == 'X' || grid[0, 0] == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case 'H':
                    if (grid[2, 1] == 'X' || grid[0, 0] == 'O')
                    {
                        return false;
                    }
                    else { return true; }

                case 'I':
                    if (grid[2, 2] == 'X' || grid[0, 0] == 'O')
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
            if (grid[0, 0] == grid[0, 1] && grid[0, 0] == grid[0, 2])
            {
                if (grid[0,0]=='X') {
                    Console.WriteLine("Player wins!");
                    return 1;
                }
                else if (grid[0, 0] == 'O') {
                    Console.WriteLine("AI wins!");
                    return 2;
                }
            }
            return 0;
        }
    }
}