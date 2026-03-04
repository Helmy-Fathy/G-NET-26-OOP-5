using G_NET_26_OOP_1;
using G_NET_26_OOP_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_2
{
    public static class BookingHelper
    {
        private static int _referenceCounter = 0;

        public static void PrintAll(IPrintable[] tickets)
        {
            Console.WriteLine("\n--- BookingHelper.PrintAll ---");
            foreach (IPrintable ticket in tickets)
                ticket.Print();
        }

        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double total = numberOfTickets * pricePerTicket;

            if (numberOfTickets >= 5)
                return total - (total * 0.10); 

            return total; 
        }

        public static string GenerateBookingReference()
        {
            _referenceCounter++;
            return $"BK-{_referenceCounter}";
        }

        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n========== Process Single Ticket ==========");
            t.Print();   
        }
    }
}
