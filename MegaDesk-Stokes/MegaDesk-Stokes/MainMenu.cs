using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Stokes
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

        private void AddQteBtn_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            Hide();
        }

        private void VwQteBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewVwQuotes = new ViewAllQuotes();
            viewVwQuotes.Tag = this;
            viewVwQuotes.Show(this);
            Hide();
        }

        private void SrchQteBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSrchQtes = new SearchQuotes();
            viewSrchQtes.Tag = this;
            viewSrchQtes.Show(this);
            Hide();
        }
    }
}
