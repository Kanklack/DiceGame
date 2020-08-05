using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int throw1 = rnd.Next(1, 6);
            int throw2 = rnd.Next(1, 6);
            int score = throw1 + throw2;

            if (score == 12)
            {
                score = 0;
            }

            else if (throw1 == throw2)
            {
                score = score * 2;
            }

            int player1score = score;

            Console.WriteLine("Player1 score: {0}", player1score);

            int p2throw1 = rnd.Next(1, 6);
            int p2throw2 = rnd.Next(1, 6);
            int p2score = p2throw1 + p2throw2;

            if (p2score == 12)
            {
                p2score = 0;
            }

            else if (p2throw1 == p2throw2)
            {
                p2score = p2score * 2;
            }

            int player2score = p2score;

            Console.WriteLine("Player2 score: {0}", player2score);

            if (player1score > player2score)
            {
                Console.WriteLine("Player 1 wins!");
            }

            else if (player1score < player2score)
            {
                Console.WriteLine("Player 2 wins!");
            }

            else
            {
                Console.WriteLine("It's a draw");
            }

            Console.ReadLine();
        }
    }
}
