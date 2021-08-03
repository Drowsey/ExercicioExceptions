using System;
using TratamentoExcecoes.Entities;

namespace TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int roomNum = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation r1 = new Reservation(roomNum, checkIn, checkOut);
            Console.Write("Reservation: " + r1);

            Console.WriteLine("\n\nEnter data to update the reservation:");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            r1.UpdateDates(checkIn, checkOut);
            Console.Write("Reservation: "+ r1 +"\n\n");
            
        }
    }
}
