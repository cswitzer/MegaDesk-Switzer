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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddQuoteBtn_Click(object sender, EventArgs e)
        {
            AddQuoteMenu addQuoteMenu = new AddQuoteMenu(this);
            addQuoteMenu.Show();
            this.Hide();
        }
    }
}
