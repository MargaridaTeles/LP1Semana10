using System;
using System.Collections.Generic;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            HashSet<int> hashset = new HashSet<int>();

            int[] values = {1, 10, -30, 10, -5};

            foreach(int v in values)
            {
                list.Add(v);
                stack.Push(v);
                queue.Enqueue(v);
                hashset.Add(v);
            }
            
            Console.WriteLine($"List: {string.Join(", ", list)}");
            Console.WriteLine($"Stack: {string.Join(", ", stack)}");
            Console.WriteLine($"Queue: {string.Join(", ", queue)}");
            Console.WriteLine($"HashSet: {string.Join(", ", hashset)}");
        }
    }
}
