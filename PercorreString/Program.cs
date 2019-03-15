using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string s, cStr;
            char c;
            //ask for a string
            Console.WriteLine("insert string");
            s = Console.ReadLine();
            //ask for a  char
            Console.WriteLine("insert char");
            cStr = Console.ReadLine();
            //convert string to char
            c = cStr[0];
            //print string
            //run string
            foreach(char cInString in s)
            {
                //current char != user char?
                if (cInString != c)
                {
                    //print current char from string
                    Console.Write(cInString);
                }
            }


        }
    }
}
