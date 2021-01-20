using System;
using System.Collections.Generic;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            FiboNumbers();

            void FiboNumbers()
            {
                var fibonacciNumbers = new List<int> { 1, 1 };

                //There are 2 items already in the List
                for (int i = 0; i < 18; i++)
                {
                    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                    fibonacciNumbers.Add(previous + previous2);

                }

                foreach (var item in fibonacciNumbers)
                    Console.WriteLine(item);
            }
            
            void ListsPractice()
            {
                var names = new List<string> { "<name>", "Ana", "Felipe" };
                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }

                Console.WriteLine();
                names.Add("Maria");
                names.Add("Bill");
                names.Remove("Ana");
                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }

                Console.WriteLine($"My name is {names[0]}.");
                Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
                Console.WriteLine($"The list has {names.Count} people in it");

                var index = names.IndexOf("Felipe");
                if (index != -1)
                    Console.WriteLine($"The name {names[index]} is at index {index}");

                var notFound = names.IndexOf("Not Found");
                Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

                names.Sort();
                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }
            }

            void CombinedBranchesLoops()
            {
                int sum = 0;
                for (int i = 0; i <= 20; i++)
                {
                    if(i % 3 == 0)
                    {
                        sum = sum + i;
                        Console.WriteLine(sum);
                    }
                }
            }
            
            void NestedForLoop()
            {
                for (int i = 0; i < 10; i++)
                {
                    for (char j = 'a'; j <'k'; j++)
                    {
                        Console.WriteLine($"The Counter is {i} , {j}");
                    }   

                }
            }

            void ForLoop()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"The Counter is {i}");
                }
            }
            
            void DoWhileCounter()
            {
                int counter = 11;
                do
                {
                    Console.WriteLine($"Hello World! The counter is {counter}");
                    counter++;
                } while (counter < 10);
            }
            
            void WhileCounter()
            {
                int counter = 0;
                while (counter < 10)
                {
                    Console.WriteLine($"Hello World! The counter is {counter}");
                    counter++;
                }
            }
            
            void IfDecisionsOr()
            {
                int a = 5;
                int b = 3;
                int c = 4;
                if ((a + b + c > 10) || (a == b))
                {
                    Console.WriteLine("The answer is greater than 10");
                    Console.WriteLine("Or the first number is equal to the second");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                    Console.WriteLine("And the first number is not equal to the second");
                }
            }
            
            void IfDecisionsAnd()
            {
                int a = 5;
                int b = 7;
                int c = 4;
                if ((a + b + c > 10) && (a == b))
                {
                    Console.WriteLine("The answer is greater than 10");
                    Console.WriteLine("And the first number is equal to the second");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                    Console.WriteLine("Or the first number is not equal to the second");
                }
            }
            
            void IfDecisions()
            {
                int a = 5;
                int b = 6;
                if (a + b > 10)
                    Console.WriteLine("The answer is greater than 10.");
                else
                    Console.WriteLine("The answer is not greater than 10.");
            }

            void CircleArea()
            {
                double radius = 2.5;
                double area = Math.Pow(radius,2) * Math.PI;
                Console.WriteLine($"Area of the Circle:  { area }");
            }

            void DecimavsDouble()
            {
                double a = 1.0;
                double b = 3.0;
                Console.WriteLine("Double " + a / b);

                decimal c = 1.0M;
                decimal d = 3.0M;
                Console.WriteLine("Decimal " + c / d);
            }
            
            void numbers1()
            {
                int b = 4;
                int c = 3;
                int a = 7;
                int d = (a + b) / c;
                int e = (a + b) % c;
                Console.WriteLine($"quotient: {d}");
                Console.WriteLine($"remainder: {e}");
            } 

            void MaxMinInt()
            {
                int max = int.MaxValue;
                int min = int.MinValue;
                
                int beyond = max + 3; //beyond becomes negative beyond max

                Console.WriteLine($"The range of integers is {min} to {max}");
                Console.WriteLine($"What happend when you go beyond Max {beyond}");

            }

            void MaxMinDouble()
            {
                double max = double.MaxValue;
                double min = double.MinValue;

                Console.WriteLine($"The range of double is {min} to {max}");
            }

            void MaxMinDecimal()
            {
                decimal max = decimal.MaxValue;
                decimal min = decimal.MinValue;

                Console.WriteLine($"The range of decimal is {min} to {max}");
            }


        }
    }
}