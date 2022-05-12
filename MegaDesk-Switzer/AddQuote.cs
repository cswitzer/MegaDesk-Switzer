using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Switzer
{
    public partial class AddQuote : Form
    {
        MainMenu _mainMenu;
        public AddQuote(MainMenu mainMenu)
        {
            InitializeComponent();

            this._mainMenu = mainMenu;

            // populate materials combobox
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
                .Cast<DesktopMaterial>()
                .ToList();

            comSurfaceMaterial.DataSource = materials;

            // populate delivery combobox
            List<RushOrderType> orders = Enum.GetValues(typeof(RushOrderType))
                .Cast<RushOrderType>()
                .ToList();

            comDelivery.DataSource = orders;

            // set default combobox to -1
            comSurfaceMaterial.SelectedIndex = comSurfaceMaterial.SelectedIndex = -1;

            // set numericupdowns to empty
            widthUpDown.Text = String.Empty;
            depthUpDown.Text = String.Empty;
            numDrawersUpDown.Text = String.Empty;
        }

        private void SaveQuotes(List<DeskQuote> quotes)
        {
            var quotesFile = $@"quotes.json";

            // serialize quotes
        }

        private void AddQuoteMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void saveQuoteBtn_Click(object sender, EventArgs e)
        {
            // create new desk

            // create new desk quote

            // get quote price

            // add quote to file

            // show data in display quote form using the current deskQuote object (pass _mainMenu and deskQuote)
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
