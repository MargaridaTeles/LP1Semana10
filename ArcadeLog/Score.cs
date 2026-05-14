using System;

namespace ArcadeLog
{
    public class Score : IComparable<Score>
    {
        // Variável de instância privada
        private int points;

        // Propriedade só de leitura
        public string Name { get; }

        // Propriedade Points (0–9999)
        public int Points
        {
            get => points;
            set
            {
                if (value < 0) points = 0;
                else if (value > 9999) points = 9999;
                else points = value;
            }
        }

        // Propriedade só de leitura Medal
        public string Medal
        {
            get
            {
                if (Points >= 7000) return "Gold";
                if (Points >= 4000) return "Silver";
                return "Bronze";
            }
        }

        // Construtor
        public Score(string name, int points)
        {
            Name = name;
            Points = points; // usa a propriedade para validar
        }

        // Ordenação descendente por pontuação
        public int CompareTo(Score other)
        {
            if (other == null) return 1;
            return other.Points.CompareTo(this.Points);
        }

        // ToString no formato pedido
        public override string ToString()
        {
            return $"{Name} [{Medal}]: {Points}";
        }
    }
}
