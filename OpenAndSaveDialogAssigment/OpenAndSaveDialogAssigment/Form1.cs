using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenAndSaveDialogAssigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void btnopen_Click_1(object sender, EventArgs e)
        {
            //openfilebutton
            DialogResult result;
            result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //import class
                StreamReader read;
                read = File.OpenText(openFileDialog1.FileName);
                String line;
                while (read.EndOfStream == false)
                {
                    line = read.ReadLine();
                    Displaying.Items.Add(line);
                }
                //closing file
                read.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("File Not Selected");
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            //savefile
            //import class
            StreamWriter writer;
            DialogResult result;
            result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                writer = File.AppendText(saveFileDialog1.FileName);
                writer.WriteLine(txtinfo.Text);
                //closing file
                writer.Close();

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("No File Selected");
            }
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            //clearing textbox and list box
            txtinfo.Clear();
            Displaying.Items.Clear();
        }
    }
}
    
    