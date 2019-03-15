using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string question, answer;

            //introduce program
            Console.WriteLine("wElcOmE tO tHe ChAtbOt ProgRaM!!");

            //ask question to user
            Console.WriteLine("wHaT is YoUr QueStIoN?");
            question = Console.ReadLine();

            //verify if question is recognised by the program and
            //give the correspondant answer
            switch (question)
            {
                case "what is your name?":
                    answer = "ChatBot";
                    break;

                case "What is your name?":
                    answer = "ChatBot";
                    break;

                case "what are you?":
                    answer = "a program designed to answer your questions, IF they are worthy of being answered";
                    break;

                case "What are you?":
                    answer = "a program designed to answer your questions, IF they are worthy of being answered";
                    break;

                case "Am I strong with the force?":
                    answer = "no, you belong in a trash can foolish mortal!";
                    break;

                case "am i strong with the force?":
                    answer = "no, you belong in a trash can foolish mortal!";
                    break;

                default:
                    answer = "I waS nOt ProgRamEd tO AnsWer ThaT....ERROR 404 NOT FOUND";
                    break;
            }
            //give an answer
            Console.WriteLine(answer);
        }

    }
}
