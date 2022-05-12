using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Switzer
{
    public enum RushOrderType
    {
        [Description("Rush 3 Days")]
        Express,
        [Description("Rush 5 Days")]
        Firstclass,
        [Description("Rush 7 Days")]
        Priority,
        [Description("No Rush")]
        Normal
    }
    public class DeskQuote
    {
        // private variables
        private int[,] _rushOrderPrices;

        // constants
        private const decimal BASE_DESK_PRICE = 200.00M;
        private const decimal SURFACE_AREA_COST = 1.00M;
        private const decimal DRAWER_COST = 50.00M;
        private const decimal OAK = 200.00M;
        private const decimal LAMINATE = 100.00M;
        private const decimal PINE = 50.00M;
        private const decimal ROSEWOOD = 300.00M;

        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public RushOrderType OrderType { get; set; }
        public decimal QuotePrice { get; set; }
        public Desk Desk { get; set; }

        public decimal GetQuotePrice()
        {
            return 0;
        }
    }
}
