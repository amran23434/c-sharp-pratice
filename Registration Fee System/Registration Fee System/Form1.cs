using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Fee_System
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
                
                string studentName = txtStudentName.Text;
                string studentId = txtStudentld.Text;

                if (string.IsNullOrWhiteSpace(studentName) || string.IsNullOrWhiteSpace(studentId))
                {
                    MessageBox.Show("Please enter the student name and ID!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtNumCourses.Text, out int numCourses) || numCourses < 1 || numCourses > 8)
                {
                    MessageBox.Show("The number of courses must be between 1 and 8!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumCourses.Focus();
                    return;
                }

                
                if (!int.TryParse(txtStudyLevel.Text, out int studyLevel) || studyLevel < 1 || studyLevel > 4)
                {
                    MessageBox.Show("The study level must be 1, 2, 3, or 4!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStudyLevel.Focus();
                    return;
                }

              
                double feePerCourse = 0;
                switch (studyLevel)
                {
                    case 1: feePerCourse = 40; break;
                    case 2: feePerCourse = 45; break;
                    case 3: feePerCourse = 50; break;
                    case 4: feePerCourse = 55; break;
                    default: throw new Exception("The study level is invalid.");
                }

                double tuitionFee = numCourses * feePerCourse;

                
                double transportFee = 0;
                double.TryParse(txtTransport.Text, out transportFee);

               
                double totalDiscount = 0;
                if (numCourses >= 6)
                {
                    totalDiscount = tuitionFee * 0.10;
                }

                double finalAmount = (tuitionFee + transportFee) - totalDiscount;

                
                lblOutName.Text = "Name : " + studentName;
                lblOutId.Text = "Id : " + studentId;
                lblOutCourses.Text = "Number Courses : " + numCourses;
                lblOutStudyYear.Text = "Study year : " + studyLevel;
                lblOutTransport.Text = "Transport Fee : $" + transportFee.ToString("F2");
                lblOutDiscount.Text = "Discount : $" + totalDiscount.ToString("F2");
                lblOutTuitioN.Text = "Tuition fee : $" + tuitionFee.ToString("F2");
                lblOutFinalAmount.Text = "Final Amount : $" + finalAmount.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtStudentld.Clear();
            txtNumCourses.Clear();
            txtStudyLevel.Clear();
            txtTransport.Clear();

            lblOutName.Text = "Name :";
            lblOutId.Text = "Id :";
            lblOutCourses.Text = "Number Courses :";
            lblOutStudyYear.Text = "Study year :";
            lblOutTransport.Text = "Transport Fee :";
            lblOutDiscount.Text = "Discount :";
            lblOutTuitioN.Text = "Tuition fee :";
            lblOutFinalAmount.Text = "Final Amount :";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

