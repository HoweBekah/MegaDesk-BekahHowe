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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void MainmenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void ValidInt(object sender, CancelEventArgs e)
        {
            Desk newDesk = new Desk();
            int newWidth;
            if (int.TryParse(widthInput.Text, out newWidth))
            {
                if (newWidth < Desk.MINWIDTH || newWidth > Desk.MAXWIDTH)
                {
                    MessageBox.Show($"Please enter a width between {Desk.MINWIDTH} inches and {Desk.MAXWIDTH} inches.");
                    widthInput.Text = "";
                    widthInput.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid, whole number width.");
                widthInput.Text = "";
                widthInput.Focus();
            }
            //just checking again again
        }

        private void GetQuote_Click(object sender, EventArgs e)
        {
            DisplayQuote viewNewQuote = new DisplayQuote();
            viewNewQuote.Tag = this;
            viewNewQuote.Show(this);
            Hide();
        }

        private void DepthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Desk newDesk = new Desk();

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                int newDepth;
                if (int.TryParse(depthInput.Text, out newDepth))
                {
                    if (newDepth < Desk.MINDEPTH || newDepth > Desk.MAXDEPTH)
                    {
                        MessageBox.Show($"Please enter a depth between {Desk.MINDEPTH} inches and {Desk.MAXDEPTH} inches.");
                        depthInput.Text = "";
                        depthInput.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid, whole number depth.");
                    depthInput.Text = "";
                    depthInput.Focus();
                }

            }

            /*if (e.Handled == false)
            {
                int newDepth;
                if (int.TryParse(widthInput.Text, out newDepth))
                {
                    if (newDepth <= Desk.MINDEPTH)
                    {
                        MessageBox.Show("Please enter a depth greater than 11in");
                    }
                    else if (newDepth >= Desk.MAXDEPTH)
                    {
                        MessageBox.Show("Please enter a depth less than 49in.");
                    }
                    else
                    {
                        newDesk.Depth = newDepth;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid depth.");
            }*/
        }

        Desk newDesk = new Desk()
        {
           
        };

        private void WidthInput_ValueChanged(object sender, EventArgs e)
        {
            if(widthInput.Value < Desk.MINWIDTH || widthInput.Value > Desk.MAXWIDTH)
            {
                MessageBox.Show($"Please enter a valid width between {Desk.MINWIDTH} inches and {Desk.MAXWIDTH} inches.");
                widthInput.ForeColor = Color.White;
                widthInput.BackColor = Color.Red;
            }
        }

        private void DepthInput_ValueChanged(object sender, EventArgs e)
        {
            if (depthInput.Value < Desk.MINDEPTH || depthInput.Value > Desk.MAXDEPTH)
            {
                MessageBox.Show($"Please enter a valid width between {Desk.MINDEPTH} inches and {Desk.MAXDEPTH} inches.");
                depthInput.ForeColor = Color.White;
                depthInput.BackColor = Color.Red;
          
            }
        }

        private void DrawersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             SurfaceMaterials SurfaceMaterials;

            switch (DrawersComboBox.Text)
            {
                case "Oak":
                    SurfaceMaterials =  SurfaceMaterials.oak;
                    break;
                case "Laminate":
                    SurfaceMaterials = SurfaceMaterials.laminate;
                    break;
                case "Pine":
                    SurfaceMaterials = SurfaceMaterials.pine;
                    break;
                case "Rosewood":
                    SurfaceMaterials = SurfaceMaterials.rosewood;
                    break;
                case "Veneer":
                    SurfaceMaterials = SurfaceMaterials.veneer;
                    break;
                default:
                    MessageBox.Show("Please Select a desktop material.");
                    break;

            }
        }

        private void RushComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RushComboBox.Text)
            {
                case "Standard Shipping (14 days)":

                    break;

                case "3 Days":
                    
                    break;

                case "5 Days":

                    break;

                case "7 Days":

                    break;

                default:
                    MessageBox.Show("Please choose shipping.");
                    break;
            }
        }
    }
}
