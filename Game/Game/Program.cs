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

            Random rand = new Random();

            Console.WriteLine("Snake & Ladder Game Started ");
            Console.WriteLine($"Player starting position: {player1Pos}");
        }
    }
}