using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<string> lista = new List<string>();
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            HashSet<string> hashset = new HashSet<string>();

            lista.Add("Banana");
            lista.Add("Pera");
            lista.Add("Manga");
            lista.Add("Banana");
            lista.Add("Maça");

            stack.Push("Banana");
            stack.Push("Pera");
            stack.Push("Manga");
            stack.Push("Banana");
            stack.Push("Maça");

            queue.Enqueue("Banana");
            queue.Enqueue("Pera");
            queue.Enqueue("Manga");
            queue.Enqueue("Banana");
            queue.Enqueue("Maça");

            hashset.Add("Banana");
            hashset.Add("Pera");
            hashset.Add("Manga");
            hashset.Add("Banana");
            hashset.Add("Maça");


            foreach(string i in lista)
            {
                Console.WriteLine(i);
            }
            Console.Write("\n");
            foreach(string i in stack)
            {
                Console.WriteLine(i);
            }
            Console.Write("\n");

            foreach(string i in queue)
            {
                Console.WriteLine(i);
            }
            Console.Write("\n");

            foreach(string i in hashset)
            {
                Console.WriteLine(i);
            }
        }
    }
}
