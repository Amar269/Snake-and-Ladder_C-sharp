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

            int diceCount = 0;

            Random rand = new Random();

            Console.WriteLine("Snake & Ladder Game Started ");
            Console.WriteLine($"Player starting position: {player1Pos}");

            while (player1Pos < 100)
            {
                int dice = rand.Next(1, 7);
                diceCount++;
                Console.WriteLine($"Dice rolled: {dice}");

                GameOption option = (GameOption)rand.Next(0, 3);

                switch (option)
                {
                    case GameOption.NoPlay:
                        Console.WriteLine("No Play");
                        break;

                    case GameOption.Ladder:
                        Console.WriteLine("Ladder");
                        if (player1Pos + dice <= 100)
                            player1Pos += dice;
                        break;

                    case GameOption.Snake:
                        Console.WriteLine("Snake");
                        player1Pos -= dice;
                        break;
                }

                if (player1Pos < 0)
                {
                    player1Pos = 0;
                }

                Console.WriteLine($"Player position: {player1Pos}");

            }
            Console.WriteLine("\n GAME OVER ");
            Console.WriteLine($"Total Dice Rolls: {diceCount}");



        }
    }
}