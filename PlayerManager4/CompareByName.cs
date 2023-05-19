using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private bool ascendente;
        private bool score = false;
        public CompareByName()
        {
            score = true;
        }

        public CompareByName(bool ascendente)
        {
            this.ascendente = ascendente;
        }

        public int Compare(Player player1, Player player2)
        {
            if(score)
            {
                return (player2.Score - player1.Score);
            }

            if(ascendente)
            {
                return(string.Compare(player1.Name, player2.Name));
            }
            else if(!ascendente)
            {
                return(string.Compare(player1.Name, player2.Name) * -1);
            }
            return 0;
        }

        
    }


}
