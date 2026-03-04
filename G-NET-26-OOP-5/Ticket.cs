using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_1
{
    public class Ticket
    {
        private static int _counter = 0;
        private string _movieName;
        private decimal _price;
        public int TicketId { get; }
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
        }

        public static int GetTotalTickets() => _counter;

        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
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

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }
    }
}
