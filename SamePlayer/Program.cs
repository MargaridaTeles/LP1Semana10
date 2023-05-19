using System;

namespace SamePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<Player> setOfPlayers = new HashSet<Player>();

            setOfPlayers.Add(new Player(PlayerType.Tank, "Margarida"));
            setOfPlayers.Add(new Player(PlayerType.Slayer, "Kadu"));
            setOfPlayers.Add(new Player(PlayerType.Slayer, "Kadu"));
            setOfPlayers.Add(new Player(PlayerType.Slayer, "Margarida"));
            setOfPlayers.Add(new Player(PlayerType.Tank, "Kadu"));
            setOfPlayers.Add(new Player(PlayerType.Tank, "Kadu"));
            setOfPlayers.Add(new Player(PlayerType.Tank, "Margarida"));

            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.Type}");
            }
        }
    }
}
