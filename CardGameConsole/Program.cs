using System;

namespace CardGameConsole
{
    class Program
    {        
        static void Main(string[] args)
        {
            int totalTurnCount = 0;
            int finiteGameCount = 0;
            for (int i = 0; i < 4; i++)
            {
                //Create game
                GameManager game = new GameManager("Prince", "Priti");
                while (!game.IsEndOfGame())
                {
                    game.PlayTurn();
                }

                if (game.TurnCount < 4)
                {
                    totalTurnCount += game.TurnCount;
                    finiteGameCount++;
                }
            }

            double avgTurn = (double)totalTurnCount / (double)finiteGameCount;

            Console.WriteLine(finiteGameCount + " finite games with an average of " + Math.Round(avgTurn, 2) + " turns per game.");

            Console.Read();
        }
    }
}
