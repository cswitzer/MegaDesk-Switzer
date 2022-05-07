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

        private void AddQuoteBtn_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteMenu = new AddQuote(this);
            addQuoteMenu.Show();
            this.Hide();
        }

        private void ViewQuotesBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes(this);
            viewAllQuotes.Show();
            this.Hide();
        }

        private void SearchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes(this);
            searchQuotes.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
