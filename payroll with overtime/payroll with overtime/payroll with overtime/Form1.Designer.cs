namespace payroll_with_overtime
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
            this.txthourseworked = new System.Windows.Forms.TextBox();
            this.lblGrosspay = new System.Windows.Forms.TextBox();
            this.txtHourlypayrate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txthourseworked
            // 
            this.txthourseworked.Location = new System.Drawing.Point(577, 65);
            this.txthourseworked.Name = "txthourseworked";
            this.txthourseworked.Size = new System.Drawing.Size(198, 26);
            this.txthourseworked.TabIndex = 0;
            // 
            // lblGrosspay
            // 
            this.lblGrosspay.Location = new System.Drawing.Point(577, 189);
            this.lblGrosspay.Name = "lblGrosspay";
            this.lblGrosspay.Size = new System.Drawing.Size(198, 26);
            this.lblGrosspay.TabIndex = 1;
            // 
            // txtHourlypayrate
            // 
            this.txtHourlypayrate.Location = new System.Drawing.Point(577, 119);
            this.txtHourlypayrate.Name = "txtHourlypayrate";
            this.txtHourlypayrate.Size = new System.Drawing.Size(198, 26);
            this.txtHourlypayrate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOURS WORKED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "HOURLY PAY RATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "GROSS PAY";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(134, 313);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(206, 101);
            this.btncalculate.TabIndex = 6;
            this.btncalculate.Text = "calculate gross pay";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(383, 324);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(111, 78);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(533, 326);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(138, 74);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 541);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHourlypayrate);
            this.Controls.Add(this.lblGrosspay);
            this.Controls.Add(this.txthourseworked);
            this.Name = "Form1";
            this.Text = "Payroll with overtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthourseworked;
        private System.Windows.Forms.TextBox lblGrosspay;
        private System.Windows.Forms.TextBox txtHourlypayrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

