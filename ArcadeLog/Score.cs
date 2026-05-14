using System;

namespace ArcadeLog
{
    public class Score : IComparable<Score>
    {
        // Variável de Instância Privada: points (int)
        // CÓDIGO AQUI
        private int points;

        // Propriedade Auto-Implementada Só de Leitura: Name (string)
        // CÓDIGO AQUI
        public string Name { get; }

        // Propriedade: Points (int), sempre entre 0 e 9999
        // CÓDIGO AQUI

        // Falta fazer entre 0 e 9999
        public int Points { get; set; }

        // Propriedade Só de Leitura: Medal (string)
        // CÓDIGO AQUI

        // Valor "Gold" se Points >= 7000, "Silver" >= 4000 else "Bronze"
        public string Medal { get; }

        // Construtor: aceita nome e pontuação
        // CÓDIGO AQUI
        public Score(string name)
        {
            Name = name;
            Points = points;
            
        }

        public int CompareTo(Score other)
        {
            if (other == null) return 1;
            return other.Points - this.points; // substitua o return
        }

        public override string ToString()
        {
            // CÓDIGO AQUI
            return $"{Name} [{Medal}]: {Points}"; // substitua o return
        }
    }
}
