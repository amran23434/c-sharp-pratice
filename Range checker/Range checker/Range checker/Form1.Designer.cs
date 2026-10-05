namespace Range_checker
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
            this.label1 = new System.Windows.Forms.Label();
            this.textrange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.TextBox();
            this.btncheckqualification = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an integer in the range of 1 through 10";
            // 
            // textrange
            // 
            this.textrange.Location = new System.Drawing.Point(268, 133);
            this.textrange.Multiline = true;
            this.textrange.Name = "textrange";
            this.textrange.Size = new System.Drawing.Size(384, 58);
            this.textrange.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Range Decision";
            // 
            // lblresult
            // 
            this.lblresult.Location = new System.Drawing.Point(117, 279);
            this.lblresult.Multiline = true;
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(678, 58);
            this.lblresult.TabIndex = 3;
            // 
            // btncheckqualification
            // 
            this.btncheckqualification.Location = new System.Drawing.Point(165, 366);
            this.btncheckqualification.Name = "btncheckqualification";
            this.btncheckqualification.Size = new System.Drawing.Size(256, 110);
            this.btncheckqualification.TabIndex = 4;
            this.btncheckqualification.Text = "Check qualification";
            this.btncheckqualification.UseVisualStyleBackColor = true;
            this.btncheckqualification.Click += new System.EventHandler(this.btncheckqualification_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(469, 366);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(197, 49);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(469, 427);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(197, 49);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 568);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncheckqualification);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textrange);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Range checker application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textrange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblresult;
        private System.Windows.Forms.Button btncheckqualification;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnExit;
    }
}

