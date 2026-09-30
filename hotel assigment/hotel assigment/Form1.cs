using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
         
        {
            try
            {
                // 1. Badal nambarada la soo geliyay
                double nights = double.Parse(txtNights.Text);
                double price = double.Parse(txtPriceNight.Text);

                // 2. Xisaabi xogta
                double subtotal = nights * price;
                double tax = subtotal * 0.10;
                double discount = subtotal * 0.05;

                // 3. Ku muuji Output Labels-ka
                lblServiceTax.Text = tax.ToString("C");
                lblDiscount.Text = discount.ToString("C");
                lblTotalAmount.Text = (subtotal + tax - discount).ToString("C");
            }
            catch (FormatException)
            {
                // Waxay qabanaysaa haddii xaraf ama eber lagu qoro leysku dayo in lagu xisaabiyo
                MessageBox.Show("Fadlan geli nambarro sax ah oo kaliya!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Waxay qabanaysaa wixii error kale oo soo kordha
                MessageBox.Show("qalad ayaa dhacay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
    }

