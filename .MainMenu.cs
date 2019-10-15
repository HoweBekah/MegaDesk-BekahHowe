using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_BekahHowe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ViewquoteBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes allQuotesView = new ViewAllQuotes();
            allQuotesView.Tag = this;
            allQuotesView.Show(this);
            Hide();
        }

        private void NewQuoteBtn_Click(object sender, EventArgs e)
        {
            AddQuote newQuote = new AddQuote();
            newQuote.Tag = this;
            newQuote.Show(this);
            Hide();
        }

        private void SearchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes quoteSearch = new SearchQuotes();
            quoteSearch.Tag = this;
            quoteSearch.Show(this);
            Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
