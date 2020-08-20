using System;

namespace TicTacToeAi
{
    class Program
    {
        static void Main(string[] args)
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
            while (difficultySelect == true)  {
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
            Console.WriteLine("Input '1' if you would like to go first, and '0' if you would like the computer to go first.");
            goFirst = Convert.ToInt32(Console.ReadLine());
            switch (selectedDifficulty)
            {
                case "easy":
                    EasyAI easyAI = new EasyAI();
                    Console.WriteLine("Here is the game board.");
                    gameBoard.DisplayBoard();
                    if (goFirst == 1)
                    {
                        while (playerWin == false && aiWin == false)
                        {
                            TakePlayerTurn(gameBoard);
                            Console.WriteLine();
                            gameBoard.DisplayBoard();
                            Console.WriteLine();
                            Console.WriteLine("The AI will now take it's turn.");
                            Console.WriteLine();
                            easyAI.TakeTurn(gameBoard);
                            gameBoard.DisplayBoard();
                            Console.WriteLine();
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
                    Console.WriteLine("That space is taken.");
                }
            }
            if (gameBoard.IsGridSpaceEmpty(selectedSpace) == true)
            {
                gameBoard.SetGridSpace(selectedSpace, 'X');
            }
        }
    }
}
