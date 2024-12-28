using System;
using System.IO;

namespace FileEditor
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            bool proceed = true;

            if(!File.Exists("filename.txt"))
            {
                File.Create("filename.txt");
            }

            while(proceed)
            {
                Console.WriteLine("Choose Operation:");
                Console.WriteLine("[1] Read File");
                Console.WriteLine("[2] Write");
                Console.WriteLine("[3] Close");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine(File.ReadAllText("filename.txt"));
                            }
                            break;

                        case 2:
                            {
                                Console.WriteLine("Write header:");
                                string header = Console.ReadLine() ?? "No header";

                                Console.WriteLine("Write content:");
                                string content = Console.ReadLine() ?? "No content";

                                using(StreamWriter sw = File.AppendText("filename.txt"))
                                {
                                    sw.WriteLine("Header:");
                                    sw.WriteLine($"-> {header}");
                                    sw.WriteLine("Content: ");
                                    sw.WriteLine($"-> {content}");
                                    sw.WriteLine();
                                }

                                Console.WriteLine(File.ReadAllText("filename.txt"));
                            }
                            break;

                        case 3:
                            {
                                Console.WriteLine("Goodbye!");
                                proceed = false;
                            }
                            break;

                        default:
                            {
                                Console.WriteLine("Enter a valid input");
                            }
                            break;
                    }
                } catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
