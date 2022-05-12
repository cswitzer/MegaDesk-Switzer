using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Switzer
{
    public partial class DisplayQuote : Form
    {
        private MainMenu _mainMenu;
        private DeskQuote _deskQuote;
        public DisplayQuote(MainMenu mainMenu, DeskQuote deskQuote)
        {
            InitializeComponent();

            _mainMenu = mainMenu;
            _deskQuote = deskQuote;
        }
    }
}
