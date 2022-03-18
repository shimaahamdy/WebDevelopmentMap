using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp.Entities
{
    public class Order
    {
        public int ID { get; set; }

        public Dollars Price { get; set; }
    }

    public readonly struct Dollars
    {
        public decimal Amount { get; }

        public Dollars(decimal _Amount) => Amount = _Amount;

        public override string ToString() => $"${Amount}";
    }
}
