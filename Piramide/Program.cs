using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string nbrLines;
            int n;
            //ask user for a line limit
            Console.WriteLine("how many lines do you want to print?");
            nbrLines = Console.ReadLine();
            n = Convert.ToInt32(nbrLines);
            //cicle
            for (int i = 0; i < n; ++i)
            {
                //declare variables
                int spc, ast;
                //determinate how many spaces
                spc = n - i - 1;
                //determninate number of asteriscs
                ast = n * 2 + 1;
                //print spaces
                for (int j = 0; j < spc; j++)
                {
                    Console.Write("");
                }
                //print asteriscs
                for (int j = 0; j < ast; j++)
                {
                    Console.Write("*");
                }
                //new line
                Console.WriteLine(); //Console.WriteLine("\n");
            }
        }
    }
}
