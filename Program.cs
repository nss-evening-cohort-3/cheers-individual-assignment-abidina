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
            String requires_an = "halfnorsemix";
            
            Console.WriteLine("What's your name?");
            Console.Write(prompt);
            String user_name = Console.ReadLine().ToLower();

            for(int i = 0; i < user_name.Length; i++) {
                if (requires_an.IndexOf(user_name[i]) > -1) {
                    // then it's in the requires_an array
                    Console.WriteLine(cheer_prefix + "n.. " + user_name[i]);
                } else {
                    // doesn't require an
                    Console.WriteLine(cheer_prefix + ".. " + user_name[i]);

                }
            }
        }
    }
}
