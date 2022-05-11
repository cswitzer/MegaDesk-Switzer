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
        }

        private void AddQuoteMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
