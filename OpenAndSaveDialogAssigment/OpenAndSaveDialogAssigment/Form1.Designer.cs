namespace OpenAndSaveDialogAssigment
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
            this.btnsave = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.Displaying = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(280, 156);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(161, 68);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(88, 149);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(161, 75);
            this.btnopen.TabIndex = 1;
            this.btnopen.Text = "open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click_1);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(88, 230);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(161, 75);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // Displaying
            // 
            this.Displaying.FormattingEnabled = true;
            this.Displaying.ItemHeight = 20;
            this.Displaying.Location = new System.Drawing.Point(503, 42);
            this.Displaying.Name = "Displaying";
            this.Displaying.Size = new System.Drawing.Size(246, 304);
            this.Displaying.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtinfo
            // 
            this.txtinfo.Location = new System.Drawing.Point(149, 60);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(100, 26);
            this.txtinfo.TabIndex = 5;
            this.txtinfo.Text = "info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 620);
            this.Controls.Add(this.txtinfo);
            this.Controls.Add(this.Displaying);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnsave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ListBox Displaying;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtinfo;
    }
}

