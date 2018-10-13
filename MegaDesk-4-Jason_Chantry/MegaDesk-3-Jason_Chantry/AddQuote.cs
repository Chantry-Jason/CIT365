using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        //Create new desk object
        Desk desk = new Desk();

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
            double cost = CalculatePrice();
            textCost.Text = cost.ToString("$#.##");

            //Write quote data to disk and exit screen
            WriteQuoteToDisk(cost);

            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();

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

        private void AddQuote_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("M/d/yyyy");
            foreach (var value in Enum.GetValues(typeof(Desk.SurfaceMaterial)))
            {
                //Console.WriteLine(value);
                listSurfaceMaterial.Items.Add(value);
            }
            foreach (var value in desk.RushOrder)
            {
                listRushOrder.Items.Add(value);
            }
        }

        private void listRushOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        //WriteQuoteToDisk method
        //This method will write quote data to a text file
        private void WriteQuoteToDisk(double cost)
        {
            

            try
            {
                using (StreamWriter writer = new StreamWriter("quotes.txt", true))
                {
                    writer.Write(DateLabel.Text + ", ");
                    writer.Write(textCustName.Text + ", ");
                    int result;
                    int.TryParse(textWidth.Text, out result);
                    writer.Write(result + ", ");
                    int.TryParse(textDepth.Text, out result);
                    writer.Write(result + ", ");
                    int.TryParse(textNumDrawers.Text, out result);
                    writer.Write(result + ", ");
                    writer.Write(listSurfaceMaterial.Text + ", ");
                    writer.Write(listRushOrder.Text + ", ");
                    writer.Write(cost);

                    writer.WriteLine();
                    Console.WriteLine("Quote saved successfully to quotes.txt");
                }
            } catch (Exception e)
            {
                Console.WriteLine("Error writing to quotes.txt.");
            }
        }

        //CalculatePrice method
        private double CalculatePrice()
        {
            //start with base price of $200
            double totalCost = 200;
            //add $1 per sq/in over 1000sq/in
            double sqInch = CalculateSurfaceArea();
            if (sqInch > 1000)
            {
                double tempSqIn = sqInch - 1000;
                totalCost += tempSqIn;
            }
            //add $50 per drawer
            double.TryParse(textNumDrawers.Text, out double result);
            totalCost += (50 * result);
            //cost for surface materials
            string temp = listSurfaceMaterial.Text;
            if (temp == "Oak") { totalCost += 200; }
            if (temp == "Laminate") { totalCost += 100; }
            if (temp == "Pine") { totalCost += 50; }
            if (temp == "Rosewood") { totalCost += 300; }
            if (temp == "Veneer") { totalCost += 125; }
            //calculate rush order cost
            string rushOrderText = listRushOrder.Text.Substring(0,2);
            Console.WriteLine(rushOrderText);
            if (rushOrderText == "3 ")
            {
                if (sqInch < 1000) { totalCost += 60; }
                if (sqInch >= 1000 && sqInch <= 2000) { totalCost += 70; }
                if (sqInch > 2000) { totalCost += 80; }
            } else if (rushOrderText == "5 ")
            {
                if (sqInch < 1000) { totalCost += 40; }
                if (sqInch >= 1000 && sqInch <= 2000) { totalCost += 50; }
                if (sqInch > 2000) { totalCost += 60; }
            } else if (rushOrderText == "7 ")
            {
                if (sqInch < 1000) { totalCost += 30; }
                if (sqInch >= 1000 && sqInch <= 2000) { totalCost += 35; }
                if (sqInch > 2000) { totalCost += 40; }
            }
            //return the total cost calculated
            return totalCost;

        }

        //Calculate Surface Area method
        private double CalculateSurfaceArea()
        {
            double wResult;
            double dResult;
            double.TryParse(textWidth.Text, out wResult);
            double.TryParse(textDepth.Text, out dResult);
            
            double sqInch = wResult * dResult;
            return sqInch;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcCostButton_Click(object sender, EventArgs e)
        {
            double cost = CalculatePrice();
            textCost.Text = cost.ToString("$#.##");
        }
    }
}



