using ElizaClasses;
using System;

namespace ElizaDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Eliza eliza = new Eliza();
            Console.WriteLine("Talk to your robot therapist, Eliza: ");
            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                string response = eliza.CreateElizaResponse(input);
                Console.WriteLine(response);
            }
        }
    }
}