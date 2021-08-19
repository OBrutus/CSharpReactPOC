using System;
using System.Collections.Generic;

namespace TaskPad
{
    public class TaskHandler
    {
        public List<Task> Tasks = new List<Task>();
        private int _runningId = 0;
        public TaskHandler()
        {
            System.Console.WriteLine("Generating Users Task Handler Object.");
        }
        
        public void CreateTask()
        {
            Task task = new Task();
            task.Id = _runningId++;
            Console.Write("Enter task Title: ");
            task.Title = Console.ReadLine();
            Console.Write("Enter task desc. or leave empty [just hit enter]: ");
            task.Description = Console.ReadLine();
            try
            {
                task.Start = GetDate(DateTime.Now);
                task.Deadline = GetDate(task.Start);
            }
            catch (Exception e)
            {
                Console.WriteLine("Try Again !! \n "+e.Message );
                return;
            }
            task.Status = GetStatus();
            task.Priority = GetPriority();
            Tasks.Add(task);
            Console.WriteLine("Task Added successfully");
        }

        private int GetPriority()
        {
            int p;
            do {
                p = int.Parse(Console.ReadLine());
            } while (p <= 0 && p > 3);
            return p;
        }

        private Status GetStatus()
        {
            while(true)
            {
                Console.WriteLine("1: TODO");
                //Console.WriteLine("2: InPROGRESS");
                Console.WriteLine("2: DONE");
                Console.WriteLine("3: PENDING");
                int input = -1;
                int.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1:
                        return Status.TODO;
                    case 2:
                        return Status.DONE;
                    case 3:
                        return Status.PENDING;
                    default:
                        Console.WriteLine("Wrong choice in status choodse an apt task");
                        break;
                }
            }
        }

        private DateTime GetDate(DateTime Upper)
        {
            Console.Write("Enter date [dd/mm/yyyy] : ");
            string input = Console.ReadLine();
            string[] a = input.Split("/");
            int dd = int.Parse(a[0]);
            int mm = int.Parse(a[1]);
            int yyyy = int.Parse(a[2]);
            var res = new DateTime(yyyy, mm, dd);
            if (res < Upper)
                throw new Exception("You have entered the date in past enter current date or fututre");
            return res;
        }
    }
}