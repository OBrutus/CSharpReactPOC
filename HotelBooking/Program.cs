using System;

namespace HotelBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t\t\t**** Welcome to Hotel ****");
            resetColor();
            Console.WriteLine(DateTime.Now);
            Console.Write("\t Enter arival time : ");
            int arrival = int.Parse(Console.ReadLine());
            Console.Write("\t Enter departure time : ");
            int depart = int.Parse(Console.ReadLine());

        }

        private static void resetColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("");
        }
    }
}
