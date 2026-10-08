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
            double weight, gravity;
            int planet;         
            string planetName = "";
            double newWeight; 

            Console.WriteLine("Space Boxing");


            Console.Write("please enter your current earth weight:  ");
            double.TryParse(Console.ReadLine(), out weight);
            
            Console.WriteLine("I have imformation for the following planets:");
            Console.WriteLine("1. Venus");
            Console.WriteLine("2. Mars");
            Console.WriteLine("3. Jupiter");
            Console.WriteLine("4. Saturn");
            Console.WriteLine("5. Uranus");
            Console.WriteLine("6. Neptune");

            Console.Write("Which planet are you visiting?");
            int.TryParse(Console.ReadLine() , out planet);

            

            if (planet == 1)
            {
                gravity = 0.78;
                planetName = "Venus";
            }
            else if (planet == 2)
            {
                gravity = 0.39;
                planetName = "Mars";
            }
            else if (planet == 3) 
            {
                gravity = 2.65;
                planetName = "Jupiter";
            }
            else if (planet == 4)
            {
                gravity = 1.17;
                planetName = "Saturn";
            }
            else if (planet == 5)
            {
                gravity = 1.05;
                planetName = "Uranus";
            }
            else if (planet == 6)
            {
                gravity = 1.23;
                planetName = "Neptune";
            }
            else
            {
                Console.WriteLine("Invalid Planet Choice.");
                return;
            }
            newWeight = weight * gravity;
            Console.WriteLine("Your Weight would be " + newWeight + " pounds on " + planetName + ".");
            //Done Spaceboxing
        }
        static void Calculator()
        {
            double num1;
            string op = Console.ReadLine();
            double num2;
            double answer = 0;
            Console.WriteLine("Calculator");
            Console.Write("Enter the first number: ");
            double.TryParse(Console.ReadLine(), out num1);

            Console.Write("Enter an operator (+, -, *, /): ");
            Console.Write("Enter the second number: ");
            double.TryParse(Console.ReadLine(), out num2);
            if (op == "+")
            {
                answer = num1 + num2;
            }
            else if ( op == "-")
            {
                answer = num1 - num2;
            }
            else if (op == "*")
            {
                answer = num1 * num2;
            }
            else if (op == "/")
            {
                if (num2 ==0)
                {
                    Console.WriteLine("You cannot divide by zero.");
                    return;

                }

                answer = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invaid Operator");
                return;
            }
            Console.WriteLine(num1 + " " + op + " " + num2 + " = " + answer);
        }
        static void MiniQuiz()
        {
            int score = 0;
            int answer1;
            string answer2 = Console.ReadLine().ToUpper();
            Console.WriteLine("Mini Quiz");
            Console.WriteLine();

            // Question 1
            Console.Write("What is 5 + 5?  ");
            int.TryParse(Console.ReadLine(), out answer1 );

            if (answer1 == 10)
            {
                Console.WriteLine("Correct! Nice Job.");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect! The answer is 10.");
            }

            Console.WriteLine();

            //Question 2
            Console.Write("What is the Captial of Canada? ");

            if (answer2 == "OTTAWA")
            {
                Console.WriteLine("Correct! Good job.");
                score++;
            }
            else
            {
                Console.WriteLine("incorrect! The answer is Ottawa.");
            }
            Console.WriteLine();

            //Question 3
        }
          


            

            
        
    }
}