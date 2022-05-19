using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        private const decimal DRAWER_COST = 50.00M;
        private const decimal OAK = 200.00M;
        private const decimal LAMINATE = 100.00M;
        private const decimal PINE = 50.00M;
        private const decimal ROSEWOOD = 300.00M;
        private const decimal VENEER = 125.00M;

        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public RushOrderType OrderType { get; set; }
        public decimal QuotePrice { get; set; }
        public Desk Desk { get; set; }

        public decimal GetQuotePrice()
        {
            decimal totalPrice = 0;
            decimal desktopSurfaceArea = this.Desk.Width * this.Desk.Depth;


            // add base price plus 1 for every lb. over 1000
            totalPrice += BASE_DESK_PRICE;
            if (desktopSurfaceArea > 1000)
                totalPrice += (desktopSurfaceArea - 1000); // e.g. 1002 SA desk adds 2 more dollars to price

            // add $50 for every drawer
            totalPrice += Desk.NumberOfDrawers * DRAWER_COST;
            
            // add price depending on material
            switch (Desk.DesktopMaterial)
            {
                case DesktopMaterial.Oak:
                    totalPrice += OAK;
                    break;
                case DesktopMaterial.Laminate:
                    totalPrice += LAMINATE;
                    break;
                case DesktopMaterial.Pine:
                    totalPrice += PINE;
                    break;
                case DesktopMaterial.Rosewood:
                    totalPrice += ROSEWOOD;
                    break;
                case DesktopMaterial.Veneer:
                    totalPrice += VENEER;
                    break;
                default:
                    totalPrice += 0;
                    break;
            }

            this.GetRushOrderPrices(); // store rush order prices in _rushOrderPrices

            // calculate price based on desk surface area and rush order type
            switch (OrderType)
            {
                case RushOrderType.Express:
                    totalPrice += CalcExpressCost(desktopSurfaceArea);
                    break;
                case RushOrderType.Priority:
                    totalPrice += CalcPriorityCost(desktopSurfaceArea);
                    break;
                case RushOrderType.Firstclass:
                    totalPrice += CalcFirstClassCost(desktopSurfaceArea);
                    break;
                case RushOrderType.Normal:
                    totalPrice += 0;
                    break;
            }

            return totalPrice;
        }

        private decimal CalcExpressCost(decimal desktopSurfaceArea)
        {
            if (desktopSurfaceArea < 1000) return _rushOrderPrices[0, 0];
            else if (desktopSurfaceArea > 1000 && desktopSurfaceArea < 2000) return _rushOrderPrices[0, 1];
            else return _rushOrderPrices[0, 2];
        }

        private decimal CalcPriorityCost(decimal desktopSurfaceArea)
        {
            if (desktopSurfaceArea < 1000) return _rushOrderPrices[1, 0];
            else if (desktopSurfaceArea > 1000 && desktopSurfaceArea < 2000) return _rushOrderPrices[1, 1];
            else return _rushOrderPrices[1, 2];
        }

        private decimal CalcFirstClassCost(decimal desktopSurfaceArea)
        {
            if (desktopSurfaceArea < 1000) return _rushOrderPrices[2, 0];
            else if (desktopSurfaceArea > 1000 && desktopSurfaceArea < 2000) return _rushOrderPrices[2, 1];
            else return _rushOrderPrices[2, 2];
        }

        private void GetRushOrderPrices()
        {
            // remember to use the "this" keyword
            this._rushOrderPrices = new int[3, 3];

            var pricesFile = @"rushOrderPrices.txt";

            try
            {
                string[] prices = File.ReadAllLines(pricesFile);
                int i = 0, j = 0;

                // store 3 arrays in a single array with rush order prices
                foreach (string price in prices)
                {
                    _rushOrderPrices[i, j] = int.Parse(price);

                    // once all rush order prices populate an array element, move onto the next array element for the next set of prices
                    if (j == 2)
                    {
                        //
                        i++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}