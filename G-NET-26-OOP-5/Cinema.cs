using G_NET_26_OOP_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_3
{
    public class Cinema
    {
        private Ticket[] _tickets = new Ticket[20];
        private Projector _projector;          

        public string CinemaName { get; }

        public Cinema(string cinemaName, string projectorModel)
        {
            CinemaName = cinemaName;
            _projector = new Projector(projectorModel);
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = t;
                    return true;
                }
            }

            Console.WriteLine("Cinema is full. Cannot add more tickets.");
            return false;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n========== All Tickets ==========");
            bool anyTicket = false;

            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] != null)
                {
                    _tickets[i].PrintTicket();
                    anyTicket = true;
                }
            }

            if (!anyTicket)
                Console.WriteLine("No tickets have been added yet.");
        }


        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            _projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine("========== Cinema Closed ==========");
            _projector.Stop();
        }

        public override string ToString()
        {
            return $"Cinema: {CinemaName} | {_projector}";
        }
    }
}
