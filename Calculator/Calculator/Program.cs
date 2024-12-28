using System;

namespace Calculator
{
    internal class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Dif(int x, int y)
        {
            return x - y;
        }

        static int Prod(int x, int y)
        {
            return x * y;
        }

        static int Quot(int x, int y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            bool proceed = true;

            while(proceed)
            {
                Console.WriteLine("Choose operation:");
                Console.WriteLine("[1] Add");
                Console.WriteLine("[2] Subtract");
                Console.WriteLine("[3] Multiply");
                Console.WriteLine("[4] Divide");
                
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch(choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter first number:");
                                int num1 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter second number:");
                                int num2 = Convert.ToInt32(Console.ReadLine());

                                int ans = Sum(num1, num2);
                                Console.WriteLine($"The answer is {ans}");
                            }
                            break;

                        case 2:
                            {
                                Console.WriteLine("Enter first number:");
                                int num1 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter second number:");
                                int num2 = Convert.ToInt32(Console.ReadLine());

                                int ans = Dif(num1, num2);
                                Console.WriteLine($"The answer is {ans}");
                            }
                            break;

                        case 3:
                            {
                                Console.WriteLine("Enter first number:");
                                int num1 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter second number:");
                                int num2 = Convert.ToInt32(Console.ReadLine());

                                int ans = Prod(num1, num2);
                                Console.WriteLine($"The answer is {ans}");
                            }
                            break;

                        case 4:
                            {
                                Console.WriteLine("Enter first number:");
                                int num1 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter second number:");
                                int num2 = Convert.ToInt32(Console.ReadLine());

                                int ans = Quot(num1, num2);
                                Console.WriteLine($"The answer is {ans}");
                            }
                            break;

                        case 5:
                            {
                                Console.WriteLine("Goodbye!");
                                proceed = false;
                            }
                            break;

                        default:
                            {
                                Console.WriteLine("Enter a valid value");
                            }
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
