using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_score_average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
        
            {
                try
                {
                    double score1, score2, score3;

                    
                    if (!double.TryParse(txtScore1.Text, out score1))
                    {
                        MessageBox.Show("Please enter a valid number: Test Score #1", "Input Error");
                        txtScore1.Focus();
                    }
                    else if (!double.TryParse(txtScore2.Text, out score2))
                    {
                        MessageBox.Show("Please enter a valid number: Test Score #2", "Input Error");
                        txtScore2.Focus();
                    }
                    else if (!double.TryParse(txtScore3.Text, out score3))
                    {
                        MessageBox.Show("Please enter a valid number: Test Score #3", "Input Error");
                        txtScore3.Focus();
                    }
                    else
                    {
                       
                        double average = (score1 + score2 + score3) / 3.0;

                        
                       lblAverage.Text = average.ToString("F1");
                    }
                }
               
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "An unexpected error occurred: " + ex.Message,
                        "System Error"
                    );
                }
            }

           
            }

        private void btnClear_Click(object sender, EventArgs e)
        {

            
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
           lblAverage.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
    }
    



        
    

    

