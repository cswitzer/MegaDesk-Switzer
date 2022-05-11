using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Switzer
{
    public enum RushOrderType
    {
        Express,
        Firstclass,
        Priority,
        Normal
    }
    internal class DeskQuote
    {
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public RushOrderType OrderType { get; set; }
        public decimal QuotePrice { get; set; }
        public Desk Desk { get; set; }

        public decimal CalcQuote()
        {
            return 0;
        }
    }
}
