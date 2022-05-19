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
using System.Reflection;
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

        private string GetDescription(Enum GenericEnum)
        {
            // gets all descriptions for any passed in enum
            // this is known as reflection, where we programmatically pull attributes and methods from a class/enum/interface
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());

            if (memberInfo != null && memberInfo.Length > 0)
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (_Attribs != null && _Attribs.Length > 0)
                {
                    return ((DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }

            return GenericEnum.ToString();
        }

        private void AddQuoteToFile(DeskQuote deskQuote)
        {
            var quotesFile = @"quotes.json";
            List<DeskQuote> deskQuotes = new List<DeskQuote>();

            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    string quotes = reader.ReadToEnd();

                    if (quotes.Length > 0)
                    {
                        // convert all json data from file into list of objects and add them to the list
                        deskQuotes = JsonSerializer.Deserialize<List<DeskQuote>>(quotes);
                    }
                }
            }

            // add the new desk quote and save the file
            deskQuotes.Add(deskQuote);
            SaveQuotes(deskQuotes);
        }

        private void SaveQuotes(List<DeskQuote> quotes)
        {
            var quotesFile = $@"quotes.json";

            // serialize quotes (convert object to json string)
            var serializedQuotes = JsonSerializer.Serialize(quotes);

            File.WriteAllText(quotesFile, serializedQuotes);
        }

        private void AddQuoteMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void saveQuoteBtn_Click(object sender, EventArgs e)
        {
            // create new desk
            var desk = new Desk()
            {
                Width = widthUpDown.Value,
                Depth = depthUpDown.Value,
                NumberOfDrawers = (int)numDrawersUpDown.Value,
                DesktopMaterial = (DesktopMaterial)comSurfaceMaterial.SelectedValue
            };

            // create new desk quote
            var deskQuote = new DeskQuote()
            {
                CustomerName = customerNameText.Text,
                Desk = desk,
                QuoteDate = DateTime.Now,
                OrderType = (RushOrderType)comDelivery.SelectedIndex // using index since we have desc.
            };

            // TODO: implement GetQuotePrice() and show deskQuote data in "DisplayQuote"
            var quotePrice = deskQuote.GetQuotePrice();

            // calculate quote price (ternary operator test until GetQuotePrice() is implemented)
            deskQuote.QuotePrice = quotePrice == 0 ? 100 : quotePrice;

            // add quote to file
            AddQuoteToFile(deskQuote);

            // show data in display quote form using the current deskQuote object (pass _mainMenu and deskQuote)
            DisplayQuote displayQuote = new DisplayQuote(_mainMenu, deskQuote);
            displayQuote.Show();
            this.Hide();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainMenu.Show();
        }
    }
}
