using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Switzer
{
    internal class AddQuote
    {
        public MainMenu mainMenu;
        public AddQuote(MainMenu mainMenu)
        {
            this.mainMenu = mainMenu;
            AddQuoteMenu addQuoteMenu = new AddQuoteMenu();
            addQuoteMenu.Show();
        }
    }
}
