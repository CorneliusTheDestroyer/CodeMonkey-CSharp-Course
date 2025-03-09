using System.Diagnostics.CodeAnalysis;

namespace PracticeApp01
{
    internal class Program
    {

        public class Player
        {
            string name;
            int myscore;
            static int totalScoreAcrossPlayersGoal = 100;

            public Player(string name, int score)
            {
                this.name = name;
                this.myscore = score;
            }

            public void GetPlayerName()
            {
                Console.WriteLine($"Player: {name}, Score: {myscore}");
            }

            public static void GetTotalScoreAcrossPlayers()
            {
                Console.WriteLine($"Total score goal across all players: {totalScoreAcrossPlayersGoal}");
            }
        }

        static void Main()
        {
            Player player01 = new Player("Marko", 15);
            Player player02 = new Player("Polo", 20);

            player01.GetPlayerName();
            player02.GetPlayerName();

            Player.GetTotalScoreAcrossPlayers();
        }
    }
}
