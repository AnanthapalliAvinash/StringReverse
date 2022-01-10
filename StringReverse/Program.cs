using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, s = "";  
            int l;               
            str = Console.ReadLine();           

            l = str.Length - 1;           
            while (l >= 0)                
            {

                s = s + str[l];  
                l--;

            }

            Console.WriteLine("Reverse of a string is{0}", s); 
            Console.ReadLine();                                                
        }
    }
}
    

