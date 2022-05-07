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
    public partial class SearchQuotes : Form
    {
        public MainMenu _mainMenu;
        public SearchQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            this._mainMenu = mainMenu;
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
