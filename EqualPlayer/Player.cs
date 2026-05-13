using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqualPlayer
{
    public class Player
    {
        public PlayerClass PClass { get; }
        public string Name { get; }
        public Player(PlayerClass pClass, string name)
        {
            PClass = pClass;
            Name = name;
        }

        public override int GetHashCode()
        {
            return PClass.GetHashCode() ^ Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Player otherPlayer = obj as Player;

            if (otherPlayer is null) 
                return false;

            if (Name.Equals(otherPlayer.Name) && PClass.Equals(otherPlayer.PClass))
                return true;
            
            return false;
        }
    }
}