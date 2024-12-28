using System;

namespace ToDoList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ToDo> list = new List<ToDo>();

            Console.WriteLine("Hello");
            bool proceed = true;
            int index = 1;

            while(proceed)
            {
                Console.WriteLine("Choose Operation:");
                Console.WriteLine("[1] Add To Do List");
                Console.WriteLine("[2] Remove To Do List");
                Console.WriteLine("[3] Update To Do List");
                Console.WriteLine("[4] Exit");
                Console.WriteLine();


                foreach (ToDo todo in list)
                {
                    Console.WriteLine($"Index: {todo.Index}");
                    Console.WriteLine($"Author: {todo.Author}");
                    Console.WriteLine($"Description: {todo.Description}");
                    Console.WriteLine();
                }

                try
                {
                    Console.WriteLine("Enter Choice:");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {

                                Console.WriteLine("Author:");
                                string author = Console.ReadLine() ?? "Unknown Author";

                                Console.WriteLine("Description:");
                                string description = Console.ReadLine() ?? "No Description";

                                ToDo todo = new ToDo(author, description);
                                todo.Index = index;

                                list.Add(todo);

                                index++;

                            }
                            break;

                        case 2:
                            {
                                foreach (ToDo todo_list in list)
                                {
                                    Console.WriteLine($"Index: {todo_list.Index}");
                                    Console.WriteLine($"Author: {todo_list.Author}");
                                    Console.WriteLine($"Description: {todo_list.Description}");
                                    Console.WriteLine();
                                }

                                Console.WriteLine("Input index:");
                                
                                try
                                {
                                    int toDelete = Convert.ToInt32(Console.ReadLine());

                                    list.RemoveAt(toDelete - 1);
                                }
                                catch (Exception e1)
                                {
                                    Console.WriteLine(e1);
                                }

                                
                            }
                            break;

                        case 3:
                            {
                                foreach(ToDo todo_list in list)
                                {
                                    Console.WriteLine($"Index: {todo_list.Index}");
                                    Console.WriteLine($"Author: {todo_list.Author}");
                                    Console.WriteLine($"Description: {todo_list.Description}");
                                    Console.WriteLine();
                                }

                                Console.WriteLine("Input index:");

                                try
                                {
                                    int toEdit = Convert.ToInt32(Console.ReadLine()) - 1;

                                    ToDo todo = list[toEdit];

                                    Console.WriteLine("Enter new author name:");
                                    todo.Author = Console.ReadLine() ?? "Unknown Author";

                                    Console.WriteLine("Enter new description:");
                                    todo.Description = Console.ReadLine() ?? "No description provided";

                                    Console.WriteLine($"Index: {todo.Index}");
                                    Console.WriteLine($"Author: {todo.Author}");
                                    Console.WriteLine($"Description: {todo.Description}");
                                }
                                catch (Exception e2)
                                {
                                    Console.WriteLine(e2);
                                }
                            }
                            break;

                        case 4:
                            {
                                Console.WriteLine("Goodbye!");
                                proceed = false;
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
