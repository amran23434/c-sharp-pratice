using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_with_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            
                try
                {
                    
                    double hoursworked, hourlyPayRate, gross;
                   
                    const double OVERTIME_RATE = 1.5;
                    
                    if (double.TryParse(txthourseworked.Text, out hoursworked) && hoursworked >= 0)
                    {
                        if (double.TryParse(txtHourlypayrate.Text, out hourlyPayRate) && hourlyPayRate >= 0)
                        {
                           
                            if (hoursworked <= 50)
                            {
                                gross = hoursworked * hourlyPayRate;
                            }
                            else
                            {
                                double overtime = hoursworked - 50;
                                gross = (50 * hourlyPayRate) + (overtime * hourlyPayRate * OVERTIME_RATE);
                            }
                        

                        lblGrosspay.Text = gross.ToString("C");
                        }
                        else
                        {

                            MessageBox.Show("invalid hourly pay rate ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid hours worked ");
                    }
                }
               
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

           

           

        private void btnclear_Click(object sender, EventArgs e)
        {

            txthourseworked.Clear();
            txtHourlypayrate.Clear();

            lblGrosspay.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    

    

