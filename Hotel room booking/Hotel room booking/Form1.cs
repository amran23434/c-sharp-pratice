using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_room_booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            lstBookingDetails.Items.Clear();

            bool isApproved = true;

            try
            {
               
                string guestName = txtguestname.Text.Trim();
                if (string.IsNullOrEmpty(guestName))
                {
                    MessageBox.Show("Fadlan geli magaca martida (Guest Name cannot be empty).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isApproved = false;
                    return;
                }

               
                int age = Convert.ToInt32(txtguestage.Text);
                if (age < 18 || age > 90)
                {
                    MessageBox.Show("Da'da martidu waa inay u dhexaysaa 18 iyo 90.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isApproved = false;
                    return;
                }

                
                int nights = Convert.ToInt32(txtnumberofnights.Text);
                if (nights < 1 || nights > 30)
                {
                    MessageBox.Show("Tadaadku habeenada waa inuu u dhexeeyaa 1 iyo 30.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isApproved = false;
                    return;
                }

                
                int guests = Convert.ToInt32(txtnumberofnights.Text);
                if (guests < 1 || guests > 6)
                {
                    MessageBox.Show("Tadaadku martidu waa inuu u dhexeeyaa 1 iyo 6.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isApproved = false;
                    return;
                }

               
                string roomType = "";
                double roomRate = 0;

                if (rdoStandard.Checked)
                {
                    roomType = "Standard";
                    if (guests > 2)
                    {
                        MessageBox.Show("Qolka Standard wuxuu qaadi karaa ugu badnaan 2 qof.", "Capacity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        isApproved = false;
                        return;
                    }
                }
                else if (rdoNormal.Checked)
                {
                    roomType = "Normal";
                    if (guests > 4)
                    {
                        MessageBox.Show("Qolka Normal wuxuu qaadi karaa ugu badnaan 4 qof.", "Capacity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        isApproved = false;
                        return;
                    }
                }
                else if (rdoHight.Checked)
                {
                    roomType = "Hight";
                    if (guests > 6)
                    {
                        MessageBox.Show("Qolka Hight wuxuu qaadi karaa ugu badnaan 6 qof.", "Capacity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        isApproved = false;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Fadlan dooro nooca qolka (Room Type).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isApproved = false;
                    return;
                }

               
                if (isApproved)
                {
                   
                    switch (roomType)
                    {
                        case "Standard":
                            roomRate = 50; 
                            break;
                        case "Normal":
                            roomRate = 80; 
                            break;
                        case "Hight":
                            roomRate = 130; 
                            break;
                    }

                    
                    double baseCost = roomRate * nights;

                   
                    double nightDiscountRate = 0;
                    if (nights >= 10)
                    {
                        nightDiscountRate = 0.12; 
                    }
                    else if (nights >= 5)
                    {
                        nightDiscountRate = 0.05;
                    }

                    double nightDiscountAmount = baseCost * nightDiscountRate;
                    double costAfterNightDiscount = baseCost - nightDiscountAmount;

                    
                    double breakfastCost = 0;
                    if (chkBreakfast.Checked)
                    {
                        breakfastCost = 10 * guests * nights;
                    }

                    
                    double surcharge = 0;
                    if (guests > 4)
                    {
                        surcharge = costAfterNightDiscount * 0.05;
                    }

                    
                    double subtotal = costAfterNightDiscount + breakfastCost + surcharge;

                    
                    double seniorDiscount = 0;
                    if (age >= 60)
                    {
                        seniorDiscount = subtotal * 0.05;
                    }

                    
                    double totalCost = subtotal - seniorDiscount;

                    
                    lstBookingDetails.Items.Add("=== BOOKING DETAILS ===");
                    lstBookingDetails.Items.Add($"Guest Name: {guestName}");
                    lstBookingDetails.Items.Add($"Age: {age}");
                    lstBookingDetails.Items.Add($"Nights: {nights}");
                    lstBookingDetails.Items.Add($"Guests: {guests}");
                    lstBookingDetails.Items.Add($"Room Type: {roomType} (${roomRate}/night)");
                    lstBookingDetails.Items.Add("-------------------------------------");
                    lstBookingDetails.Items.Add($"Base Room Cost: ${baseCost:F2}");
                    if (nightDiscountAmount > 0)
                        lstBookingDetails.Items.Add($"Night Discount ({nightDiscountRate * 100}%): -${nightDiscountAmount:F2}");
                    if (breakfastCost > 0)
                        lstBookingDetails.Items.Add($"Breakfast Option: +${breakfastCost:F2}");
                    if (surcharge > 0)
                        lstBookingDetails.Items.Add($"Group Surcharge (5%): +${surcharge:F2}");
                    if (seniorDiscount > 0)
                        lstBookingDetails.Items.Add($"Senior Discount (5%): -${seniorDiscount:F2}");
                    lstBookingDetails.Items.Add("-------------------------------------");
                    lstBookingDetails.Items.Add($"TOTAL PRICE: ${totalCost:F2}");
                }
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Fadlan geli nambaro sax ah oo kaliya qeybaha Age, Nights, iyo Guests.", "Input Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                
                MessageBox.Show("Nambarka aad gelisay waa ka weyn yahay xadkiisa.", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Cilad aan la filayn ayaa dhacday: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

       

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtguestname.Clear();
            txtguestage.Clear();
            txtnumberofnights.Clear();
            txtnumberofguest.Clear();

            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHight.Checked = false;

            chkBreakfast.Checked = false;

            lstBookingDetails.Items.Clear();
            txtguestname.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
        
    


