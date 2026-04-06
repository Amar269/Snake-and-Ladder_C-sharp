using System;

namespace SnakeLadderGame
{
    enum GameOption
    {
        NoPlay = 0,
        Ladder = 1,
        Snake = 2
    }

    class Program
    {
        static void Main()
        {
            int player1Pos = 0;
            int player2Pos = 0;

            int currentPlayer = 1;
            int diceCount = 0;

            Random rand = new Random();

            Console.WriteLine("Snake & Ladder Game Started ");

            while (player1Pos < 100 && player2Pos < 100)
            {
                int dice = rand.Next(1, 7);
                diceCount++;

                Console.WriteLine($"\nPlayer {currentPlayer} rolled: {dice}");

                GameOption option = (GameOption)rand.Next(0, 3);

                int tempPos = (currentPlayer == 1) ? player1Pos : player2Pos;

                switch (option)
                {
                    case GameOption.NoPlay:
                        Console.WriteLine("No Play");
                        break;

                    case GameOption.Ladder:
                        Console.WriteLine("Ladder");
                        if (tempPos + dice <= 100)
                            tempPos += dice;
                        break;

                    case GameOption.Snake:
                        Console.WriteLine("Snake");
                        tempPos -= dice;
                        break;
                }

                if (tempPos < 0)
                    tempPos = 0;

                if (currentPlayer == 1)
                    player1Pos = tempPos;
                else
                    player2Pos = tempPos;

                Console.WriteLine($"P1: {player1Pos} | P2: {player2Pos}");

                
                if (option != GameOption.Ladder)
                {
                    currentPlayer = (currentPlayer == 1) ? 2 : 1;
                }
            }

            Console.WriteLine("\n GAME OVER ");

            if (player1Pos == 100)
                Console.WriteLine("Player 1 Wins!");
            else
                Console.WriteLine("Player 2 Wins!");

            Console.WriteLine($"Total Dice Rolls: {diceCount}");
        }
    }
}