namespace Registration_Fee_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IblStudentName = new System.Windows.Forms.Label();
            this.IblStudentld = new System.Windows.Forms.Label();
            this.IblNumCourses = new System.Windows.Forms.Label();
            this.IblStudyLevel = new System.Windows.Forms.Label();
            this.txtAccommodation = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentld = new System.Windows.Forms.TextBox();
            this.txtNumCourses = new System.Windows.Forms.TextBox();
            this.txtStudyLevel = new System.Windows.Forms.TextBox();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOutName = new System.Windows.Forms.Label();
            this.lblOutId = new System.Windows.Forms.Label();
            this.lblOutCourses = new System.Windows.Forms.Label();
            this.lblOutStudyYear = new System.Windows.Forms.Label();
            this.lblOutTransport = new System.Windows.Forms.Label();
            this.lblOutDiscount = new System.Windows.Forms.Label();
            this.lblOutTuitioN = new System.Windows.Forms.Label();
            this.lblOutFinalAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IblStudentName
            // 
            this.IblStudentName.AutoSize = true;
            this.IblStudentName.Location = new System.Drawing.Point(103, 43);
            this.IblStudentName.Name = "IblStudentName";
            this.IblStudentName.Size = new System.Drawing.Size(155, 20);
            this.IblStudentName.TabIndex = 0;
            this.IblStudentName.Text = "Enter Student Name";
            // 
            // IblStudentld
            // 
            this.IblStudentld.AutoSize = true;
            this.IblStudentld.Location = new System.Drawing.Point(103, 92);
            this.IblStudentld.Name = "IblStudentld";
            this.IblStudentld.Size = new System.Drawing.Size(127, 20);
            this.IblStudentld.TabIndex = 1;
            this.IblStudentld.Text = "Enter Student Id";
            // 
            // IblNumCourses
            // 
            this.IblNumCourses.AutoSize = true;
            this.IblNumCourses.Location = new System.Drawing.Point(103, 151);
            this.IblNumCourses.Name = "IblNumCourses";
            this.IblNumCourses.Size = new System.Drawing.Size(186, 20);
            this.IblNumCourses.TabIndex = 2;
            this.IblNumCourses.Text = "Enter Number of courses";
            // 
            // IblStudyLevel
            // 
            this.IblStudyLevel.AutoSize = true;
            this.IblStudyLevel.Location = new System.Drawing.Point(103, 202);
            this.IblStudyLevel.Name = "IblStudyLevel";
            this.IblStudyLevel.Size = new System.Drawing.Size(134, 20);
            this.IblStudyLevel.TabIndex = 3;
            this.IblStudyLevel.Text = "Enter Study Level";
            // 
            // txtAccommodation
            // 
            this.txtAccommodation.AutoSize = true;
            this.txtAccommodation.Location = new System.Drawing.Point(103, 262);
            this.txtAccommodation.Name = "txtAccommodation";
            this.txtAccommodation.Size = new System.Drawing.Size(109, 20);
            this.txtAccommodation.TabIndex = 4;
            this.txtAccommodation.Text = "Transport Fee";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(326, 37);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(217, 26);
            this.txtStudentName.TabIndex = 5;
            // 
            // txtStudentld
            // 
            this.txtStudentld.Location = new System.Drawing.Point(326, 86);
            this.txtStudentld.Name = "txtStudentld";
            this.txtStudentld.Size = new System.Drawing.Size(217, 26);
            this.txtStudentld.TabIndex = 6;
            // 
            // txtNumCourses
            // 
            this.txtNumCourses.Location = new System.Drawing.Point(326, 145);
            this.txtNumCourses.Name = "txtNumCourses";
            this.txtNumCourses.Size = new System.Drawing.Size(217, 26);
            this.txtNumCourses.TabIndex = 7;
            // 
            // txtStudyLevel
            // 
            this.txtStudyLevel.Location = new System.Drawing.Point(326, 196);
            this.txtStudyLevel.Name = "txtStudyLevel";
            this.txtStudyLevel.Size = new System.Drawing.Size(217, 26);
            this.txtStudyLevel.TabIndex = 8;
            // 
            // txtTransport
            // 
            this.txtTransport.Location = new System.Drawing.Point(326, 256);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(217, 26);
            this.txtTransport.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(87, 295);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(192, 65);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(326, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 65);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(546, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 65);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOutName
            // 
            this.lblOutName.AutoSize = true;
            this.lblOutName.Location = new System.Drawing.Point(103, 401);
            this.lblOutName.Name = "lblOutName";
            this.lblOutName.Size = new System.Drawing.Size(51, 20);
            this.lblOutName.TabIndex = 13;
            this.lblOutName.Text = "Name";
            // 
            // lblOutId
            // 
            this.lblOutId.AutoSize = true;
            this.lblOutId.Location = new System.Drawing.Point(103, 449);
            this.lblOutId.Name = "lblOutId";
            this.lblOutId.Size = new System.Drawing.Size(23, 20);
            this.lblOutId.TabIndex = 14;
            this.lblOutId.Text = "Id";
            // 
            // lblOutCourses
            // 
            this.lblOutCourses.AutoSize = true;
            this.lblOutCourses.Location = new System.Drawing.Point(103, 509);
            this.lblOutCourses.Name = "lblOutCourses";
            this.lblOutCourses.Size = new System.Drawing.Size(128, 20);
            this.lblOutCourses.TabIndex = 15;
            this.lblOutCourses.Text = "Number Courses";
            // 
            // lblOutStudyYear
            // 
            this.lblOutStudyYear.AutoSize = true;
            this.lblOutStudyYear.Location = new System.Drawing.Point(103, 561);
            this.lblOutStudyYear.Name = "lblOutStudyYear";
            this.lblOutStudyYear.Size = new System.Drawing.Size(84, 20);
            this.lblOutStudyYear.TabIndex = 16;
            this.lblOutStudyYear.Text = "Study year";
            // 
            // lblOutTransport
            // 
            this.lblOutTransport.AutoSize = true;
            this.lblOutTransport.Location = new System.Drawing.Point(509, 401);
            this.lblOutTransport.Name = "lblOutTransport";
            this.lblOutTransport.Size = new System.Drawing.Size(109, 20);
            this.lblOutTransport.TabIndex = 17;
            this.lblOutTransport.Text = "Transport Fee";
            // 
            // lblOutDiscount
            // 
            this.lblOutDiscount.AutoSize = true;
            this.lblOutDiscount.Location = new System.Drawing.Point(509, 449);
            this.lblOutDiscount.Name = "lblOutDiscount";
            this.lblOutDiscount.Size = new System.Drawing.Size(72, 20);
            this.lblOutDiscount.TabIndex = 18;
            this.lblOutDiscount.Text = "Discount";
            // 
            // lblOutTuitioN
            // 
            this.lblOutTuitioN.AutoSize = true;
            this.lblOutTuitioN.Location = new System.Drawing.Point(509, 509);
            this.lblOutTuitioN.Name = "lblOutTuitioN";
            this.lblOutTuitioN.Size = new System.Drawing.Size(88, 20);
            this.lblOutTuitioN.TabIndex = 19;
            this.lblOutTuitioN.Text = "Tuition Fee";
            // 
            // lblOutFinalAmount
            // 
            this.lblOutFinalAmount.AutoSize = true;
            this.lblOutFinalAmount.Location = new System.Drawing.Point(509, 561);
            this.lblOutFinalAmount.Name = "lblOutFinalAmount";
            this.lblOutFinalAmount.Size = new System.Drawing.Size(103, 20);
            this.lblOutFinalAmount.TabIndex = 20;
            this.lblOutFinalAmount.Text = "Final Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 666);
            this.Controls.Add(this.lblOutFinalAmount);
            this.Controls.Add(this.lblOutTuitioN);
            this.Controls.Add(this.lblOutDiscount);
            this.Controls.Add(this.lblOutTransport);
            this.Controls.Add(this.lblOutStudyYear);
            this.Controls.Add(this.lblOutCourses);
            this.Controls.Add(this.lblOutId);
            this.Controls.Add(this.lblOutName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.txtStudyLevel);
            this.Controls.Add(this.txtNumCourses);
            this.Controls.Add(this.txtStudentld);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtAccommodation);
            this.Controls.Add(this.IblStudyLevel);
            this.Controls.Add(this.IblNumCourses);
            this.Controls.Add(this.IblStudentld);
            this.Controls.Add(this.IblStudentName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblStudentName;
        private System.Windows.Forms.Label IblStudentld;
        private System.Windows.Forms.Label IblNumCourses;
        private System.Windows.Forms.Label IblStudyLevel;
        private System.Windows.Forms.Label txtAccommodation;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentld;
        private System.Windows.Forms.TextBox txtNumCourses;
        private System.Windows.Forms.TextBox txtStudyLevel;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOutName;
        private System.Windows.Forms.Label lblOutId;
        private System.Windows.Forms.Label lblOutCourses;
        private System.Windows.Forms.Label lblOutStudyYear;
        private System.Windows.Forms.Label lblOutTransport;
        private System.Windows.Forms.Label lblOutDiscount;
        private System.Windows.Forms.Label lblOutTuitioN;
        private System.Windows.Forms.Label lblOutFinalAmount;
    }
}

