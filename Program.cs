using System;

namespace SelectionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rightAnswer = false;
            var r1 = new Random();
            var favoriteNumber = r1.Next(100);
            do
            {
                Console.WriteLine("Can you guess my favortite number?");
                var userInput = int.Parse(Console.ReadLine());

                if (userInput < favoriteNumber)
                {
                    string[] lowArrary = { "Sorry, that's to low. Try again.", "Good Try,but not quite right.", "Almost there, try again." };
                    var r2 = new Random();
                    string lowOutput = lowArrary[r2.Next(lowArrary.Length)];
                    Console.WriteLine(lowOutput);
                }
                else if (userInput > favoriteNumber)
                {
                    string[] highArrary = { "Woah too high,Guess again.", "Almost got it, give another try", "Oh no! too high!" };
                    var r3 = new Random();
                    string highOutput = highArrary[r3.Next(highArrary.Length)];
                    Console.WriteLine(highOutput);
                }
                else if (userInput == favoriteNumber)
                {
                    string[] winArrary = { " You did it!!", "B I N G O!!!", "Hooray!! Your Rihgt!" };
                    Console.WriteLine(winArrary);
                }
                else
                {
                    Console.WriteLine("Nevermind");
                }
            } while (rightAnswer == false);
        }
    }
}
