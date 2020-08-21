using System;

namespace TicTacToeAi
{
    class Program
    {
        //TODO: REFACTOR ROUND WIN CODE INTO A METHOD
        static void Main(string[] args)
        {
            bool playAgain = true;
            string playAgainInput;
            while (playAgain == true)
            {
                Board gameBoard = new Board();
                bool difficultySelect = true;
                int goFirst;
                string selectedDifficulty = "";
                bool playerWin = false;
                bool aiWin = false;
                Console.WriteLine("Welcome to Tic Tac Toe.");
                Console.WriteLine("For this game, you will be represente by X, and the AI represented by O.");
                gameBoard.DisplayBoard();
                while (difficultySelect == true)
                {
                    Console.WriteLine("Input your desired difficulty: 1 for easy, 2 for medium, 3 for hard. Input 'help' for a description of each difficulty.");
                    string difficultyInput = Console.ReadLine();
                    switch (difficultyInput)
                    {
                        case "help":
                            Console.WriteLine("EASY: The AI will make random moves.");
                            Console.WriteLine("MEDIUM: The AI will make random moves, unless it sees that you are about to make a winning move, in which case it will attempt to block it.");
                            Console.WriteLine("HARD: The AI will try to win. This AI is unbeatable, and every game will result in the game being a draw or a win for the AI.");
                            break;

                        case "1":
                            selectedDifficulty = "easy";
                            difficultySelect = false;
                            break;

                        case "2":
                            selectedDifficulty = "medium";
                            difficultySelect = false;
                            break;

                        case "3":
                            selectedDifficulty = "hard";
                            difficultySelect = false;
                            break;

                        default:
                            Console.WriteLine("Your input was invalid. Please try again.");
                            break;
                    }
                }
                Console.WriteLine("Input '1' if you would like to go first, and '2' if you would like the computer to go first.");
                goFirst = Convert.ToInt32(Console.ReadLine());
                switch (selectedDifficulty)
                {
                    case "easy":
                        EasyAI easyAI = new EasyAI();
                        Console.WriteLine("Here is the game board.");
                        gameBoard.DisplayBoard();
                        if (goFirst == 1)
                        {
                            while (true)
                            {
                                TakePlayerTurn(gameBoard);
                                Console.WriteLine();
                                gameBoard.DisplayBoard();
                                Console.WriteLine();
                                switch (LookForGameEnd(gameBoard, easyAI))
                                {
                                    case 3:
                                        Console.WriteLine("The game is drawn.");
                                        goto GameEnded;

                                    case 2:
                                        Console.WriteLine("The AI has won!");
                                        goto GameEnded;

                                    case 1:
                                        Console.WriteLine("The player has won!");
                                        goto GameEnded;

                                    case 0:
                                        break;
                                }
                                Console.WriteLine("The AI will now take it's turn.");
                                easyAI.TakeTurn(gameBoard);
                                Console.WriteLine();
                                gameBoard.DisplayBoard();
                                Console.WriteLine();
                                switch (LookForGameEnd(gameBoard, easyAI))
                                {
                                    case 3:
                                        Console.WriteLine("The game is drawn.");
                                        goto GameEnded;

                                    case 2:
                                        Console.WriteLine("The AI has won!");
                                        goto GameEnded;

                                    case 1:
                                        Console.WriteLine("The player has won!");
                                        goto GameEnded;

                                    case 0:
                                        break;
                                }
                            }
                        }
                        else if (goFirst == 2)
                        {
                            while (aiWin == false && playerWin == false)
                            {
                                Console.WriteLine("The AI will now take it's turn.");
                                easyAI.TakeTurn(gameBoard);
                                Console.WriteLine();
                                gameBoard.DisplayBoard();
                                Console.WriteLine();
                                switch (LookForGameEnd(gameBoard, easyAI))
                                {
                                    case 3:
                                        Console.WriteLine("The game is drawn.");
                                        goto GameEnded;

                                    case 2:
                                        Console.WriteLine("The AI has won!");
                                        goto GameEnded;

                                    case 1:
                                        Console.WriteLine("The player has won!");
                                        goto GameEnded;

                                    case 0:
                                        break;
                                }
                                TakePlayerTurn(gameBoard);
                                Console.WriteLine();
                                gameBoard.DisplayBoard();
                                Console.WriteLine();
                                switch (LookForGameEnd(gameBoard, easyAI))
                                {
                                    case 3:
                                        Console.WriteLine("The game is drawn.");
                                        goto GameEnded;

                                    case 2:
                                        Console.WriteLine("The AI has won!");
                                        goto GameEnded;

                                    case 1:
                                        Console.WriteLine("The player has won!");
                                        goto GameEnded;

                                    case 0:
                                        break;
                                }
                            }
                        }
                        break;

                    case "medium":
                        Console.WriteLine("This difficulty level is still under development.");
                        break;

                    case "hard":
                        Console.WriteLine("This difficulty level is still under development.");
                        break;
                }
                GameEnded:
                Console.WriteLine();
                Console.WriteLine("Would you like to play again?");
                playAgainInput = Console.ReadLine();
                if (playAgainInput == "no" | playAgainInput == "n" | playAgainInput == "nope" | playAgainInput == "nah")
                {
                    playAgain = false;
                    Console.WriteLine("Thank you for playing.");
                    Console.ReadLine();
                }
                Console.WriteLine();
            }
        }
        static void TakePlayerTurn(Board gameBoard)
        {
            char selectedSpace = 'Z';
            bool selectedSpaceEmpty = false;
            while (selectedSpaceEmpty == false)
            {
                Console.WriteLine("Which space would you like to play?");
                selectedSpace = Convert.ToChar(Console.ReadLine());
                selectedSpaceEmpty = gameBoard.IsGridSpaceEmpty(selectedSpace);
                if (selectedSpaceEmpty == false)
                {
                    Console.WriteLine("That space is invalid.");
                }
            }
            if (gameBoard.IsGridSpaceEmpty(selectedSpace) == true)
            {
                gameBoard.SetGridSpace(selectedSpace, 'X');
            }
        }
        static int LookForGameEnd (Board gameBoard, EasyAI easyAI)
        {
            //0 for no win, 1 for player win, 2 for AI win, 3 for draw
            if (gameBoard.CheckWin() == 0 && gameBoard.BoardFull() == true)
            {
                return 3;
            }
            if (gameBoard.CheckWin() == 1)
            {
                return 1;
            }
            else if (gameBoard.CheckWin() == 2)
            {
                return 2;
            }
            return 0;
        }
    }
}
