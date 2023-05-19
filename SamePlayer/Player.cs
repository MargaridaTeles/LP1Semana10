using System;
using System.Collections.Generic;

namespace SamePlayer
{
    public class Player 
    {
        public PlayerType Type { get; set; }
        public string Name { get; set; }

        public Player(PlayerType type, string name)
        {
            Type = type;
            Name = name;
        }

        public override int GetHashCode()
        {
            return Type.GetHashCode() ^ Name.GetHashCode();
        }

        public override bool Equals(object other)
        {
            
            return Type.Equals((other as Player).Type) && Name.Equals((other as Player).Name);
        }
    }
}