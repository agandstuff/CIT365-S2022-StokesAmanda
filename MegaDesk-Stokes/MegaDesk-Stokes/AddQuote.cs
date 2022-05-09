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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        int MINWIDTH = Desk.MINWIDTH;
        int MAXWIDTH = Desk.MAXWIDTH;
        private object errorProvider1;

        private void submitOrderBtn_Click(object sender, EventArgs e)
        {
            //How to pass objects between forms
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if(!ValidWidth(widthInput.Text, out errorMsg))
            {
                e.Cancel = true;
                widthInput.Select(0, widthInput.Text.Length);
            }
        }

        public bool ValidWidth(string widthInput, out string errorMessage)
        {
            int width = Convert.ToInt32(widthInput);
            if(width < MINWIDTH)
            {
                errorMessage = "Width is too small, enter a larger number";
                return false;
            } else if(width > MAXWIDTH)
            {
                errorMessage = "Width is too big, enter a smaller number";
                return false;
            }
            errorMessage = "";
            return true;
        }
    }
}
