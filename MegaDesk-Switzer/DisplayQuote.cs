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
            SetQuoteValues();
        }

        private void SetQuoteValues()
        {
            customerNameText2.Text = _deskQuote.CustomerName;
            widthUpDown2.Value = _deskQuote.Desk.Width;
            depthUpDown2.Value = _deskQuote.Desk.Depth;
            numDrawersUpDown2.Value = _deskQuote.Desk.NumberOfDrawers;
            comSurfaceMaterial2.Text = _deskQuote.Desk.DesktopMaterial.ToString();
            comDelivery2.Text = _deskQuote.OrderType.ToString();

            // make all fields readonly
            customerNameText2.ReadOnly = true;
            widthUpDown2.ReadOnly = true;
            widthUpDown2.Controls[0].Visible = false;
            depthUpDown2.ReadOnly = true;
            depthUpDown2.Controls[0].Visible = false;
            numDrawersUpDown2.ReadOnly = true;
            numDrawersUpDown2.Controls[0].Visible = false;
            comSurfaceMaterial2.Enabled = false;
            comDelivery2.Enabled = false;
            totalPriceText.ReadOnly = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            _mainMenu.Show();
            this.Close();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
