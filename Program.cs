using System;
using TratamentoExcecoes.Entities;
using TratamentoExcecoes.Entities.Exceptions;

namespace TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
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
                Console.Write("Reservation: " + r1 + "\n\n");

            }
            catch (DomainException e)
            {
                Console.WriteLine("Reservation error: " + e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format error: Only numbers must be typed in room number");
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}
