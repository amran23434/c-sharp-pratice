using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {




            lstBookingDetails.Items.Clear();
            bool bookingApproved = true;
            try
            {
                
                string passengerName = txtPassengerName.Text.Trim();
                if (string.IsNullOrEmpty(passengerName))
                {
                    MessageBox.Show(
                        "Please enter the passenger's name.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                
                int age;
                if (!int.TryParse(txtPassengerAge.Text, out age))
                {
                    MessageBox.Show(
                        "Please enter a valid number for age.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if (age < 1 || age > 100)
                {
                    MessageBox.Show(
                        "The passenger's age must be between 1 and 100.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                
                int tickets;
                if (!int.TryParse(txtNumberOfTickets.Text, out tickets))
                {
                    MessageBox.Show(
                        "Please enter a valid number of tickets.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if (tickets < 1 || tickets > 5)
                {
                    MessageBox.Show(
                        "The number of tickets must be between 1 and 5.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                
                double baggageWeight;
                if (!double.TryParse(
                    txtBaggageWeight.Text, out baggageWeight))
                {
                    MessageBox.Show(
                        "Please enter a valid baggage weight.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if (baggageWeight < 0 ||
                    baggageWeight > (50 * tickets))
                {
                    MessageBox.Show(
                        $"Baggage weight cannot be negative or exceed {50 * tickets} kg.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
              
                string travelClass = "";
                double ticketPrice = 0;
                if (rdoFirstClass.Checked)
                {
                    travelClass = "First Class";
                    ticketPrice = 300;
                    if (age < 12)
                    {
                        MessageBox.Show(
                            "Passengers under 12 years old cannot book First Class. The booking has been rejected.",
                            "Booking Rejected",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        bookingApproved = false;
                        return;
                    }
                }
                else if (rdoNormalClass.Checked)
                {
                    travelClass = "Normal Class";
                    ticketPrice = 150;
                }
                else if (rdoBusinessClass.Checked)
                {
                    travelClass = "Business Class";
                    ticketPrice = 250;
                }
                else
                {
                    MessageBox.Show(
                        "Please select a travel class.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
               
                if (bookingApproved)
                {
                    double basicTicketCost = ticketPrice * tickets;
                    
                    double ticketDiscountRate = 0;
                    if (tickets == 5)
                        ticketDiscountRate = 0.10;
                    else if (tickets >= 3)
                        ticketDiscountRate = 0.05;
                    double ticketDiscountAmount =
                        basicTicketCost * ticketDiscountRate;
                    double costAfterTicketDiscount =
                        basicTicketCost - ticketDiscountAmount;
                    
                    double ageDiscountRate = 0;
                    if (age < 12)
                        ageDiscountRate = 0.20;
                    else if (age >= 60)
                        ageDiscountRate = 0.10;
                    double ageDiscountAmount =
                        costAfterTicketDiscount * ageDiscountRate;
                    double costAfterAgeDiscount =
                        costAfterTicketDiscount - ageDiscountAmount;
                 
                    double insuranceCost =
                        chkInsurance.Checked ? 25 * tickets : 0;
                    
                    double allowedFreeBaggage = 20 * tickets;
                    double extraBaggageCost = 0;
                    if (baggageWeight > allowedFreeBaggage)
                    {
                        extraBaggageCost =
                            (baggageWeight - allowedFreeBaggage) * 10;
                    }
                    
                    double totalCost =
                        costAfterAgeDiscount +
                        insuranceCost +
                        extraBaggageCost;
                    
                    lstBookingDetails.Items.Add(
                        "=== AIRLINE BOOKING DETAILS ===");
                    lstBookingDetails.Items.Add(
                        $"Passenger Name: {passengerName}");
                    lstBookingDetails.Items.Add(
                        $"Passenger Age: {age}");
                    lstBookingDetails.Items.Add(
                        $"Number of Tickets: {tickets}");
                    lstBookingDetails.Items.Add(
                        $"Baggage Weight: {baggageWeight} kg");
                    lstBookingDetails.Items.Add(
                        $"Travel Class: {travelClass} (${ticketPrice}/ticket)");
                    lstBookingDetails.Items.Add(
                        "-------------------------------------");
                    lstBookingDetails.Items.Add(
                        $"Basic Ticket Cost: ${basicTicketCost:F2}");
                    if (ticketDiscountAmount > 0)
                    {
                        lstBookingDetails.Items.Add(
                            $"Ticket Discount: -${ticketDiscountAmount:F2}");
                    }
                    if (ageDiscountAmount > 0)
                    {
                        lstBookingDetails.Items.Add(
                            $"Age Discount: -${ageDiscountAmount:F2}");
                    }
                    if (insuranceCost > 0)
                    {
                        lstBookingDetails.Items.Add(
                            $"Travel Insurance: +${insuranceCost:F2}");
                    }
                    if (extraBaggageCost > 0)
                    {
                        lstBookingDetails.Items.Add(
                            $"Extra Baggage Surcharge: +${extraBaggageCost:F2}");
                    }
                    lstBookingDetails.Items.Add(
                        "-------------------------------------");
                    lstBookingDetails.Items.Add(
                        $"TOTAL PRICE: ${totalCost:F2}");
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "The number you entered exceeds the allowed range.",
                    "Overflow Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        
       
        
      

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtNumberOfTickets.Clear();
            txtBaggageWeight.Clear();
            rdoFirstClass.Checked = false;
            rdoNormalClass.Checked = false;
            rdoBusinessClass.Checked = false;
            chkInsurance.Checked = false;
            lstBookingDetails.Items.Clear();
            txtPassengerName.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}