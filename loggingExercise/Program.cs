using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace loggingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number");
            string userInput = Console.ReadLine();
            File.WriteAllText(@"C:\Users\jacob\Desktop\cSharpLogFiles\log.txt", userInput);
            Console.WriteLine("You typed in:  " + File.ReadAllText(@"C:\Users\jacob\Desktop\cSharpLogFiles\log.txt"));
            Console.ReadLine();
        }
    }
}
