using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_Jason_Chantry
{
    public partial class AddQuote : Form
    {
        //initialize Error Providers
        private System.Windows.Forms.ErrorProvider textWidthErrorProvider;
        private System.Windows.Forms.ErrorProvider textDepthErrorProvider;

        public AddQuote()
        {
            InitializeComponent();
            //Setup validated error handlers
            this.textWidth.Validated += new System.EventHandler(this.textWidth_Validated);
            this.textDepth.Validated += new System.EventHandler(this.textDepth_Validated);

            //Create and set the ErrorProvider for width data entry control
            textWidthErrorProvider = new System.Windows.Forms.ErrorProvider();
            textWidthErrorProvider.SetIconAlignment(this.textWidth, ErrorIconAlignment.MiddleLeft);
            textWidthErrorProvider.SetIconPadding(this.textWidth, 2);
            textWidthErrorProvider.BlinkRate = 1000;
            textWidthErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            textDepthErrorProvider = new System.Windows.Forms.ErrorProvider();
            textDepthErrorProvider.SetIconAlignment(this.textDepth, ErrorIconAlignment.MiddleLeft);
            textDepthErrorProvider.SetIconPadding(this.textDepth, 2);
            textDepthErrorProvider.BlinkRate = 1000;
            textDepthErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void btnCreateQuote_Click(object sender, EventArgs e)
        {

        }
        
        private void textDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
             {
                e.Handled = true;
            } else
            {
                e.Handled = false;
            }
        }
        private void textWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


        //validate the textWidth field

        private void textWidth_Validated(object sender, System.EventArgs e)
        {
            
            int fieldValue;
            //Check to see if user entered a valid integer value
            if (int.TryParse(textWidth.Text, out fieldValue))
            {
                //The value is an integer
                if (fieldValue < 24 || fieldValue > 96)
                {
                    this.textWidth.Select(0, textWidth.Text.Length);
                    
                    textWidthErrorProvider.SetError(this.textWidth, "Must be  between 24 and 96");
                } else
                {
                    textWidthErrorProvider.SetError(this.textWidth, String.Empty);
                }
            } else
            {
                //The value is not an integer
                
                textWidthErrorProvider.SetError(this.textWidth, "Not a valid integer.");
            }
            

        }
        //validate the textDepth field

        private void textDepth_Validated(object sender, System.EventArgs e)
        {

            int fieldValue;
            //Check to see if user entered a valid integer value
            if (int.TryParse(textDepth.Text, out fieldValue))
            {
                //The value is an integer
                if (fieldValue < 12 || fieldValue > 48)
                {
                    this.textDepth.Select(0, textDepth.Text.Length);

                    textDepthErrorProvider.SetError(this.textDepth, "Must be  between 12 and 48");
                }
                else
                {
                    textDepthErrorProvider.SetError(this.textDepth, String.Empty);
                }
            }
            else
            {
                //The value is not an integer

                textDepthErrorProvider.SetError(this.textDepth, "Not a valid integer.");
            }


        }

    }
}



