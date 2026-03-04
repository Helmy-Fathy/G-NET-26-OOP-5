using G_NET_26_OOP_1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_3
{
    public class IMAXTicket : Ticket
    {
        private bool _is3D;

        public bool Is3D
        {
            get { return _is3D; }
            set
            {
                if (_is3D == value) return; 

                if (value)
                    Price += 30m;
                else
                    Price -= 30m;

                _is3D = value;
            }
        }

        public IMAXTicket(string movieName, decimal price, bool is3D): base(movieName, price)
        {
            Is3D = is3D;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"   IMAX 3D: {(Is3D ? "Yes" : "No")}");
        }

        public override string ToString()
        {
            return base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
        }
    }
}
