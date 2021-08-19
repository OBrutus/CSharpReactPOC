using System;
using System.Web.Helpers;

namespace TaskPad
{
    class Program
    {
        private TaskHandler tasks;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your own personal tasks handler");
            var user = new Program();
            user.tasks = new TaskHandler();
            int input = 1;
            while (input != 0)
            {
                user.displayMenu();
                Console.WriteLine("Enter your choice : ");
                input = int.Parse(Console.ReadLine());
                user.chooser(input);
            }
        }

        private void displayMenu()
        {
            Console.WriteLine("---------Menu--------");
            Console.WriteLine("1: create a new task ");
            Console.WriteLine("2: display your tasks ");
            Console.WriteLine("3: view task by id ");
            Console.WriteLine("4: view all ");
            Console.WriteLine("5: Edit ");
            Console.WriteLine("6: Delete ");
            Console.WriteLine("0: Exit ");
        }

        private void chooser(int input)
        {
            switch (input)
            {
                case 0:
                    Console.WriteLine($"Exiting have a nice day ");
                    break;
                case 1: // create task
                    this.tasks.CreateTask();
                    break;
                case 2: Console.WriteLine("Ignore it [depricated] "); break;
                case 3: // view task by id
                    int id;
                    if(int.TryParse(Console.ReadLine(), out id))
                        this.tasks.Tasks.Find(t => t.Id == id);
                    else
                        Console.WriteLine("Wrong Choice");
                    break;
                case 4: // view all
                    Console.WriteLine(this.tasks.Tasks);
                    break;
                case 5: // edit task
                    break;
                case 6: // delete 
                    break;
                default:
                    Console.WriteLine("Wrong choice try again");
                    break;
            }
        }
    }
}
