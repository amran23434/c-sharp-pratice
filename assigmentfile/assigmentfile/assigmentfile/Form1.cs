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

namespace assigmentfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_the_file_Click(object sender, EventArgs e)
        {
            
            try
                
            {
                using (StreamWriter sw = File.CreateText("docPath.txt"))
                {
                    sw.WriteLine("Item 1: Computer");
                    sw.WriteLine("Item 2: Keyboard");
                    sw.WriteLine("Item 3: Mouse");
                    sw.WriteLine("Item 4: Monitor");
                }
                MessageBox.Show("New file 'MyData.txt' created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating file: " + ex.Message);
            }
        }

        private void btn_read_the_file_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("docPath.txt"))
                {
                    string[] allData = File.ReadAllLines("docPath.txt");
                    listBox1.Items.Clear();

                    for (int i = 0; i < allData.Length; i++)
                    {
                        listBox1.Items.Add(allData[i]);
                    }
                    MessageBox.Show("Data loaded into ListBox.");
                }
                else
                {
                    MessageBox.Show("File does not exist yet. Click create first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        private void remove_item_file_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = listBox1.SelectedIndex;

                if (selectedIndex != -1)
                {
                    listBox1.Items.RemoveAt(selectedIndex);

                    // Re-save remaining items back into file
                    using (StreamWriter writer = File.CreateText("docPath.txt"))
                    {
                        foreach (object item in listBox1.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }
                    MessageBox.Show("Selected row deleted and file updated!");
                }
                else
                {
                    MessageBox.Show("Please select an item from the list to remove.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing item: " + ex.Message);
            }
        }

        private void remove_file_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("docPath.txt"))
                {
                    File.Delete("docPath.txt");
                    listBox1.Items.Clear();
                    MessageBox.Show("File 'MyData.txt' has been permanently deleted.");
                }
                else
                {
                    MessageBox.Show("Nothing to delete. File does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting file: " + ex.Message);
            }
        }
    }
}
