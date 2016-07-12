using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Var section
            String prompt = "> ";
            String cheer_prefix = "Give me a";
            
            Console.WriteLine("What's your name?");
            Console.Write(prompt);
            String user_name = Console.ReadLine();

            for(int i = 0; i < user_name.Length; i++) {
                Console.WriteLine(cheer_prefix + ".. " + user_name[i]);
            }

            Console.WriteLine(user_name.ToUpper() + " is.. GRAND!");
        }
    }
}
