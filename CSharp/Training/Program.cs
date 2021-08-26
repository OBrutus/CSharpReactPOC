using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            int option = 1;
            while(option != 0) {
                Console.WriteLine("*** menu **** \n" +
                    "1 : Value and refrence type \n" +
                    "2 : String Operation \n" +
                    "0 : Exit"); 
                Console.Write("Input choice __ : ");
                
                option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        new ValueAndRefrenceType().Run();
                        break;
                    case 2:
                        new StringOpearations().Run();
                        break;
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
