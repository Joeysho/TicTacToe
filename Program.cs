using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace TicTacToe
{
    internal class Program
    {
        static string boardTemplate;
        static bool check;
        static bool emptySpace;
        static int player1Turn;
        static int player2Turn;
        static bool gameWon = false;
        static bool gameTie = false;
        static string[,] board =
            {
                {"","",""},
                {"","",""},
                {"","",""}
            };

        static void Main(string[] args)
        {

            TicTacToeHeader();


            while (!gameWon || !gameTie)
            {

                // get input of player 1
                Player1Input();
                Player1ChoiceValidation();

                // check if game won
                GameWonChecker();
                if (gameWon)
                    break;

                //check if game tie
                GameTieCheck();
                if (gameTie)
                    break;

                // get input of player 2
                Player2Input();
                Player2ChoiceValidation();

                // check if game won
                GameWonChecker();

                //check if game tie
                GameTieCheck();

            }
            Console.ReadLine();


        }

        public static string TicTacToeHeader()
        {
            return boardTemplate = string.Format(@"      |     |   
   1  |  2  |  3
______|_____|____
      |     |   
   4  |  5  |  6
______|_____|____
      |     |   
   7  |  8  |  9
      |     |");
        }

        public static int Player1Input()
        {
            Console.WriteLine(boardTemplate);

            // get input of player 1
            Console.Write("Player 1: Choose your field! ");
            check = int.TryParse(Console.ReadLine(), out player1Turn);
            Console.Clear();

            // validate input of player 1
            while (!check || player1Turn < 1 || player1Turn > 9)
            {
                Console.WriteLine(boardTemplate);
                Console.WriteLine("Enter a valid Space 1-9!");
                Console.Write("Player 1: Choose your field! ");
                check = int.TryParse(Console.ReadLine(), out player1Turn);
                Console.Clear();
            }

            return player1Turn;
        }

        public static int Player2Input()
        {
            Console.WriteLine(boardTemplate);

            // get input of player 2
            Console.Write("Player 2: Choose your field! ");
            check = int.TryParse(Console.ReadLine(), out player2Turn);
            Console.Clear();

            // validate input of player 2
            while (!check || player2Turn < 1 || player2Turn > 9)
            {
                Console.WriteLine(boardTemplate);
                Console.WriteLine("Enter a valid Space 1-9!");
                Console.Write("Player 2: Choose your field! ");
                check = int.TryParse(Console.ReadLine(), out player2Turn);
                Console.Clear();
            }

            return player2Turn;
        }

        public static void Player1ChoiceValidation()
        {
            emptySpace = false;

            while (!emptySpace)
            {
                switch (player1Turn)
                {
                    case 1:
                        if (board[0, 0] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player1Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[0, 0] = "X";
                            boardTemplate = boardTemplate.Replace("1", "X");
                        }
                        break;
                    case 2:
                        if (board[0, 1] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player1Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[0, 1] = "X";
                            boardTemplate = boardTemplate.Replace("2", "X");
                        }
                        break;
                    case 3:
                        if (board[0, 2] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player1Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[0, 2] = "X";
                            boardTemplate = boardTemplate.Replace("3", "X");
                        }
                        break;
                    case 4:
                        if (board[1, 0] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player1Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[1, 0] = "X";
                            boardTemplate = boardTemplate.Replace("4", "X");
                        }
                        break;
                    case 5:
                        if (board[1, 1] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player1Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[1, 1] = "X";
                            boardTemplate = boardTemplate.Replace("5", "X");
                        }
                        break;
                    case 6:
                        if (board[1, 2] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player1Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[1, 2] = "X";
                            boardTemplate = boardTemplate.Replace("6", "X");
                        }
                        break;
                    case 7:
                        if (board[2, 0] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player1Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[2, 0] = "X";
                            boardTemplate = boardTemplate.Replace("7", "X");
                        }
                        break;
                    case 8:
                        if (board[2, 1] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player1Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[2, 1] = "X";
                            boardTemplate = boardTemplate.Replace("8", "X");
                        }
                        break;
                    case 9:
                        if (board[2, 2] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player1Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[2, 2] = "X";
                            boardTemplate = boardTemplate.Replace("9", "X");
                        }
                        break;
                }
            }
        }

        public static void Player2ChoiceValidation()
        {
            emptySpace = false;

            while (!emptySpace)
            {
                switch (player2Turn)
                {
                    case 1:
                        if (board[0, 0] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player2Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[0, 0] = "O";
                            boardTemplate = boardTemplate.Replace("1", "O");
                        }
                        break;
                    case 2:
                        if (board[0, 1] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player2Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[0, 1] = "O";
                            boardTemplate = boardTemplate.Replace("2", "O");
                        }
                        break;
                    case 3:
                        if (board[0, 2] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player2Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[0, 2] = "O";
                            boardTemplate = boardTemplate.Replace("3", "O");
                        }
                        break;
                    case 4:
                        if (board[1, 0] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player2Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[1, 0] = "O";
                            boardTemplate = boardTemplate.Replace("4", "O");
                        }
                        break;
                    case 5:
                        if (board[1, 1] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player2Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[1, 1] = "O";
                            boardTemplate = boardTemplate.Replace("5", "O");
                        }
                        break;
                    case 6:
                        if (board[1, 2] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player2Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[1, 2] = "O";
                            boardTemplate = boardTemplate.Replace("6", "O");
                        }
                        break;
                    case 7:
                        if (board[2, 0] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player2Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[2, 0] = "O";
                            boardTemplate = boardTemplate.Replace("7", "O");
                        }
                        break;
                    case 8:
                        if (board[2, 1] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player2Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[2, 1] = "O";
                            boardTemplate = boardTemplate.Replace("8", "O");
                        }
                        break;
                    case 9:
                        if (board[2, 2] != "")
                        {
                            emptySpace = false;
                            Console.WriteLine("Space already taken!");
                            Player2Input();
                            break;
                        }
                        else
                        {
                            emptySpace = true;
                            board[2, 2] = "O";
                            boardTemplate = boardTemplate.Replace("9", "O");
                        }
                        break;
                }
            }
        }

        public static bool GameWonChecker()
        {
            //HORIZONTAL WIN CHECK
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, 0] == "X" && board[i, 1] == "X" && board[i, 2] == "X")
                    {
                        Console.WriteLine(boardTemplate);
                        Console.WriteLine("Player 1 wins Horizontally");
                        return gameWon = true;

                    }

                    if (board[i, 0] == "O" && board[i, 1] == "O" && board[i, 2] == "O")
                    {
                        Console.WriteLine(boardTemplate);
                        Console.WriteLine("Player 2 wins Horizontally");
                        return gameWon = true;
                    }
                }
            }


            //VERTICAL WIN CHECK
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[0, i] == "X" && board[1, i] == "X" && board[2, i] == "X")
                    {
                        Console.WriteLine(boardTemplate);
                        Console.WriteLine("Player 1 wins Vertically");
                        return gameWon = true;
                        //break;
                    }

                    if (board[0, i] == "O" && board[1, i] == "O" && board[2, i] == "O")
                    {
                        Console.WriteLine(boardTemplate);
                        Console.WriteLine("Player 2 wins Vertically");
                        return gameWon = true;
                        //break;
                    }
                }
            }

            //DIAGONAL1 CHECK
            if (board[0, 0] == "X" && board[1, 1] == "X" && board[2, 2] == "X")
            {
                Console.WriteLine(boardTemplate);
                Console.WriteLine("Player 1 wins Diagonally!");
                return gameWon = true;
            }
            if (board[0, 0] == "O" && board[1, 1] == "O" && board[2, 2] == "O")
            {
                Console.WriteLine(boardTemplate);
                Console.WriteLine("Player 2 wins Diagonally!");
                return gameWon = true;
            }


            //DIAGONAL 2 CHECK
            int countX = 0;
            int countO = 0;
            for (int i = 0, j = 2; i < board.GetLength(0); i++, j--)
            {
                if (board[i, j] == "X")
                {
                    countX++;

                    if (countX >= 3)
                    {
                        Console.WriteLine(boardTemplate);
                        Console.WriteLine("Player 1 wins Diagonally!");
                        return gameWon = true;
                    }
                }

                if (board[i, j] == "O")
                {
                    countO++;

                    if (countO >= 3)
                    {
                        Console.WriteLine(boardTemplate);
                        Console.WriteLine("Player 2 wins Diagonally!");
                        return gameWon = true;
                    }
                }
            }
            return gameWon = false;

        }

        public static bool GameTieCheck()
        {
            int count = 0;
            //check if game tie
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != "")
                    {
                        count++;

                        if (count >= 9)
                        {
                            Console.WriteLine(boardTemplate);
                            Console.WriteLine("It's a TIE!");
                            return gameTie = true;
                        }
                    }
                }
            }

            return gameTie = false;
        }

    }
}

