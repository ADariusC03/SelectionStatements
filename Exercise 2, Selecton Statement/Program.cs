using System;

namespace Exercise_2__Selecton_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your favorite subject in school");

            var subject = Console.ReadLine(); //evalute to a string

            switch (subject)
            {
                case "Science":
                    Console.WriteLine("Science is an intresting subject.");
                    break;
                case "Math":
                    Console.WriteLine("Nice, Math is my favorite subject also!!");
                    break;
                case "History":
                    Console.WriteLine("HIstory is a good and exciting subject.");
                    break;
                case "English":
                    Console.WriteLine("English is tricky but an okay subject.");
                    break;
                case "Computer Science":
                    Console.WriteLine("Computer Science is the way to be! Glad this your favorite.");
                    break;
                default:
                    Console.WriteLine($"Awe man, I haven't taken {subject} before. Sounds cool!");
                    break;
            }

        }
    }
}
