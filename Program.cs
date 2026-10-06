using System.Xml.Schema;

namespace Topic_5_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a program:");
            Console.WriteLine("1. Space Boxing");
            Console.WriteLine("2. Simple Calculator");
            Console.WriteLine("3. Mini Quiz");

            Console.Write("Enter your choice:  ");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);

            if (choice == 1)
            {
                SpaceBoxing();
            }
            else if (choice == 2)
            {
                Calculator();
            }
            else if (choice == 3)
            {
                MiniQuiz();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }


        static void SpaceBoxing()
        {
            Console.WriteLine("Space Boxing");


            Console.Write("please enter your current earth weight:  ");
            double weight;
            double.TryParse(Console.ReadLine(), out weight);

            Console.WriteLine("I have imformation for the following planets:");
            Console.WriteLine("1. Venus");
            Console.WriteLine("2. Mars");
            Console.WriteLine("3. Jupiter");
            Console.WriteLine("4. Saturn");
            Console.WriteLine("5. Uranus");
            Console.WriteLine("6. Neptune");

            Console.Write("Which planet are you visiting?");
            int planet;
            int.TryParse(Console.ReadLine() , out planet);

            double gravity = 0;
            string plantName = "";

            if (planet == 1)
            {
                gravity = 0.78;
                planetName = "Venus";
            }
            //Almost done
        }
        static void Calculator()
        {
            Console.WriteLine("Calculator");
        }
        static void MiniQuiz()
        {
            Console.WriteLine("Mini Quiz");
        }
          


            

            
        
    }
}