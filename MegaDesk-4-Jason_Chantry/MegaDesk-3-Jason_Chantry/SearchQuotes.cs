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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            listSurfaceMaterial.DataSource = Enum.GetNames(typeof(Desk.SurfaceMaterial));
            DateLabel.Text = DateTime.Now.ToString("M/d/yyyy");

        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResultsListView.Clear();
            try
            {
                //get selected surface material and assign to string
                string SearchSurfaceMaterial = listSurfaceMaterial.SelectedItem.ToString();
                //check that the file is present and then read in data from csv
                if (!File.Exists(@"quotes.txt"))
                {
                    MessageBox.Show("Can not find the quotes.txt file.", "Error reading file");

                } else
                {
                    //Add headers to list view
                    ResultsListView.Columns.Add("#", 30, HorizontalAlignment.Center);
                    ResultsListView.Columns.Add("Date", 120, HorizontalAlignment.Center);
                    ResultsListView.Columns.Add("Name", 170, HorizontalAlignment.Center);
                    ResultsListView.Columns.Add("Width", 70, HorizontalAlignment.Center);
                    ResultsListView.Columns.Add("Depth", 70, HorizontalAlignment.Center);
                    ResultsListView.Columns.Add("Drawers", 80, HorizontalAlignment.Center);
                    ResultsListView.Columns.Add("Surface Material", 120, HorizontalAlignment.Center);
                    ResultsListView.Columns.Add("Rush Order", 70, HorizontalAlignment.Center);
                    ResultsListView.Columns.Add("Cost", 100, HorizontalAlignment.Center);

                    //read in file
                    using (var reader = new StreamReader(@"quotes.txt"))
                    {
                        int numQuotes = 0;
                        while (!reader.EndOfStream)
                        {
                            string[] values = reader.ReadLine().Split(',');
                            
                            if (values[5].Trim() == SearchSurfaceMaterial) //Won't compare for some reason

                            {
                                numQuotes++;
                                ResultsListView.Items.Add(new ListViewItem(new[]
                                {
                                    numQuotes.ToString(), values[0], values[1], values[2], values[3], values[4],
                                     values[5], values[6], "$"+values[7]
                                }));

                            }
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("There was a problem with listing the quotes using StremReader." + "\n\n" + ex);
            }
        }
    }
        
    
                      
    
}
