using System;
using Session101Ex1.Entities;
using Session101Ex1.Entities.Exceptions;

namespace Session101Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int room = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());
                
                Reservation reservation = new Reservation(room, checkin, checkout);
                
                Console.WriteLine(reservation);
                
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();
                
                reservation.UpdateDates(checkin, checkout);
                
                Console.WriteLine(reservation);

            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation: {e.Message}");
            }
            
        }
    }
}