using System;
using System.IO;

namespace FilePower2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string fileName = args[0];
            Console.WriteLine("Insere texto (linha vazia para terminar):");

            using StreamWriter writer = new StreamWriter(fileName);
            string input;

            do
            {
                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                    writer.WriteLine(input);

            } while (!string.IsNullOrEmpty(input));
        }
    }
}
