using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace purchase_informatio
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
                int Numberofpackes;
                double Priceperpackage;

                if (!int.TryParse(txtnumberofpackage.Text, out Numberofpackes) ||
                    !double.TryParse(txtpriceperpackage.Text, out Priceperpackage) ||
                    Numberofpackes <= 0 || Priceperpackage <= 0)
                {
                    MessageBox.Show("Please enter correct values");
                    return;
                }

                double subtotal = Numberofpackes * Priceperpackage;
                double discountRate;

                if (Numberofpackes >= 100)
                    discountRate = 0.50;
                else if (Numberofpackes >= 50)
                    discountRate = 0.40;
                else if (Numberofpackes >= 20)
                    discountRate = 0.30;
                else if (Numberofpackes >= 10)
                    discountRate = 0.20;
                else
                    discountRate = 0.0;

                double discount = subtotal * discountRate;
                double total = subtotal - discount;

                lstResults.Items.Clear();
                lstResults.Items.Add("Purchase Results");
                lstResults.Items.Add("Number of Packages: " + Numberofpackes);
                lstResults.Items.Add("Price per Package: " + Priceperpackage.ToString());
                lstResults.Items.Add("Subtotal: " + subtotal.ToString("C2"));
                lstResults.Items.Add("Discount Rate: " + (discountRate * 100) + "%");
                lstResults.Items.Add("Discount Amount: " + discount.ToString("C2"));
                lstResults.Items.Add("Total Amount: " + total.ToString("C2"));
            }
            catch (Exception ex) { 
            MessageBox.Show(
                   "An error occurred: {ex.Message}",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }
            }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnumberofpackage.Clear();
            txtpriceperpackage.Clear();
            lstResults.Items.Clear();
            
        }

        

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


        }




    


