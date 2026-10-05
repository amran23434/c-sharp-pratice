using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncheckqualification_Click(object sender, EventArgs e)
       
            {
                try
                {
                    //creating variable
                    int number;
                    //validating the input type
                    if (int.TryParse(textrange.Text, out number))
                    {
                        //checking if the number is in the range
                        if (number >= 1 && number <= 10)
                        {
                            //displaying the output
                            lblresult.Text = number.ToString() + "The number is in the range";
                        }
                        else
                        {
                            lblresult.Text = number.ToString() + "The number is not in the range";

                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid please enter an integer number ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        private void btnclear_Click(object sender, EventArgs e)
        {

            textrange.Clear();
            lblresult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    

    

