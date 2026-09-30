using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        
           
        {
            try
            {
                
                if (int.TryParse(txtNights.Text, out int nights) && double.TryParse(txtPriceNight.Text, out double pricePerNight))
                {
                    
                    double subtotal = nights * pricePerNight;

                    
                    double serviceTax = subtotal * 0.10;
                    double discount = subtotal * 0.05;

                    
                    double totalAmount = subtotal + serviceTax - discount;

                    
                    lblServiceTax.Text = serviceTax.ToString("C");
                    lblDiscount.Text = discount.ToString("C");
                    lblTotalAmount.Text = totalAmount.ToString("C");
                }
                else
                {
                    MessageBox.Show("Fadlan geli nambarro sax ah oo ku saabsan tirada habeenada iyo qiimaha!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mowduuc galitaan koodh ah ayaa dhacay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

