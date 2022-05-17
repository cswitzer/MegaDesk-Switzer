using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_Switzer
{
    public partial class ViewAllQuotes : Form
    {
        private List<DeskQuote> _deskQuotes;
        public MainMenu _mainMenu;
        public ViewAllQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private List<DeskQuote> GetAllQuotes()
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
                        deskQuotes = JsonSerializer.Deserialize<List<DeskQuote>>(quotes);
                    }
                }
            }

            return deskQuotes;
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            _deskQuotes = GetAllQuotes();
            dataGridView1.DataSource = _deskQuotes;
        }
    }
}
