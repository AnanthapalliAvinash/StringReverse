using System;

namespace FibnacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, n;
            Console.Write("Enter the number of elements");
            n = int.Parse(Console.ReadLine());
            Console.Write(n1 +" ");   
            Console.Write(n2 +" ");
            for (i = 2;i<n;i++)    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }
    }
}
