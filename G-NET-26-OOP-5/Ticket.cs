using G_NET_26_OOP_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_1
{
    public class Ticket : IPrintable, IBookable, ICloneable
    {
        private static int _counter = 0;
        private string _movieName;
        private decimal _price;
        public int TicketId { get; }
        public bool IsBooked { get; private set; }
        public string MovieName
        {
            get { return _movieName; }
            set { if (!string.IsNullOrWhiteSpace(value)) _movieName = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { if (value > 0) _price = value; }
        }

        public decimal PriceAfterTax
        {
            get { return _price + (_price * 0.14m); }
        }

        public Ticket(string movieName, decimal price)
        {
            _counter++;
            TicketId = _counter;
            MovieName = movieName;
            Price = price;
            IsBooked = false;
        }

        public static int GetTotalTickets() => _counter;

        public virtual void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | Price: {Price} |After Tax: {PriceAfterTax} |Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public bool Book()
        {
            if (IsBooked)
            {
                Console.WriteLine($"[Ticket #{TicketId}] is already booked.");
                return false;
            }
            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked)
            {
                Console.WriteLine($"[Ticket #{TicketId}] is not booked — nothing to cancel.");
                return false;
            }
            IsBooked = false;
            return true;
        }

        public void SetPrice(decimal price)
        {
            Price = price;
            Console.WriteLine($"Setting price directly: {Price}");
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            decimal result = basePrice * multiplier;
            Price = result;
            Console.WriteLine($"Setting price with multiplier: {basePrice} x {multiplier} = {Price}");
        }

        public virtual object Clone()
        {
            return new Ticket(this.MovieName, this.Price);
        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP | Booked: {(IsBooked ? "Yes" : "No")}";
        }
    }
}
