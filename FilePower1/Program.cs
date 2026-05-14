using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string fileName = args[0];
            Queue<string> queue = new Queue<string>();

            string input;

            do
            {
                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                    queue.Enqueue(input);

            } while (!string.IsNullOrEmpty(input));

            using StreamWriter writer = new StreamWriter(fileName);

            while (queue.Count > 0)
                writer.WriteLine(queue.Dequeue());

            Console.WriteLine($"Conteúdo guardado em '{fileName}'.");
        }
    }
}
