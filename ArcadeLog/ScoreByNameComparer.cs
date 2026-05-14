using System;
using System.Collections.Generic;

namespace ArcadeLog
{
    public class ScoreByNameComparer : IComparer<Score>
    {
        private bool ascending;

        public ScoreByNameComparer(bool ascending)
        {
            this.ascending = ascending;
        }

        public int Compare(Score x, Score y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            if (ascending)
                return x.Name.CompareTo(y.Name);
                
            return y.Name.CompareTo(x.Name);
        }
    }
}