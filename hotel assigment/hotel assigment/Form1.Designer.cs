namespace hotel_assigment
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
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtPriceNight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtroomttype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblServiceTax = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(449, 58);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(196, 26);
            this.txtRoomType.TabIndex = 0;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(449, 168);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(196, 26);
            this.txtNights.TabIndex = 2;
            // 
            // txtPriceNight
            // 
            this.txtPriceNight.Location = new System.Drawing.Point(449, 221);
            this.txtPriceNight.Name = "txtPriceNight";
            this.txtPriceNight.Size = new System.Drawing.Size(196, 26);
            this.txtPriceNight.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ENTER GUEST NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ENTER ROOM TYPE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ENTERNUMBEROFNIGHTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ENTERPRICEPERNIGHT";
            // 
            // txtroomttype
            // 
            this.txtroomttype.FormattingEnabled = true;
            this.txtroomttype.Items.AddRange(new object[] {
            "Deluxe",
            "Standard",
            "Suite"});
            this.txtroomttype.Location = new System.Drawing.Point(449, 118);
            this.txtroomttype.Name = "txtroomttype";
            this.txtroomttype.Size = new System.Drawing.Size(196, 28);
            this.txtroomttype.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Service Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Discount Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Amount";
            // 
            // lblServiceTax
            // 
            this.lblServiceTax.Location = new System.Drawing.Point(542, 359);
            this.lblServiceTax.Name = "lblServiceTax";
            this.lblServiceTax.Size = new System.Drawing.Size(196, 26);
            this.lblServiceTax.TabIndex = 12;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Location = new System.Drawing.Point(542, 410);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(196, 26);
            this.lblDiscount.TabIndex = 13;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Location = new System.Drawing.Point(542, 461);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(196, 26);
            this.lblTotalAmount.TabIndex = 14;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(283, 266);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(362, 70);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate Booking";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 551);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblServiceTax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtroomttype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPriceNight);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtRoomType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtPriceNight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtroomttype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lblServiceTax;
        private System.Windows.Forms.TextBox lblDiscount;
        private System.Windows.Forms.TextBox lblTotalAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

