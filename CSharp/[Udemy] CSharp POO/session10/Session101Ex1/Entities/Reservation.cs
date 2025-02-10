using Session101Ex1.Entities.Exceptions;

namespace Session101Ex1.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; private set; }
        public DateTime Checkout { get; private set; }

        public Reservation() { }
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Error in reservation: Check-out must be after check-in date.");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan t = Checkout.Subtract(Checkin);
            return t.Days;
        }
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for update must be future dates.");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out must be after check-in date.");
            }
            Checkin = checkin;
            Checkout = checkout;
        }
        public override string ToString()
        {
            return $"Reservation: Room {RoomNumber}, check-in: {Checkin.ToShortDateString()}, check-out: {Checkout.ToShortDateString()}, {Duration()} nights";
        }
    }
}
