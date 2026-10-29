namespace assigmentfile
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
            this.btn_create_the_file = new System.Windows.Forms.Button();
            this.btn_read_the_file = new System.Windows.Forms.Button();
            this.remove_item_file = new System.Windows.Forms.Button();
            this.remove_file_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_create_the_file
            // 
            this.btn_create_the_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_the_file.Location = new System.Drawing.Point(50, 61);
            this.btn_create_the_file.Name = "btn_create_the_file";
            this.btn_create_the_file.Size = new System.Drawing.Size(205, 83);
            this.btn_create_the_file.TabIndex = 0;
            this.btn_create_the_file.Text = "Create the file";
            this.btn_create_the_file.UseVisualStyleBackColor = true;
            this.btn_create_the_file.Click += new System.EventHandler(this.btn_create_the_file_Click);
            // 
            // btn_read_the_file
            // 
            this.btn_read_the_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read_the_file.Location = new System.Drawing.Point(298, 61);
            this.btn_read_the_file.Name = "btn_read_the_file";
            this.btn_read_the_file.Size = new System.Drawing.Size(205, 83);
            this.btn_read_the_file.TabIndex = 1;
            this.btn_read_the_file.Text = "read the file";
            this.btn_read_the_file.UseVisualStyleBackColor = true;
            this.btn_read_the_file.Click += new System.EventHandler(this.btn_read_the_file_Click);
            // 
            // remove_item_file
            // 
            this.remove_item_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_item_file.Location = new System.Drawing.Point(50, 198);
            this.remove_item_file.Name = "remove_item_file";
            this.remove_item_file.Size = new System.Drawing.Size(205, 83);
            this.remove_item_file.TabIndex = 2;
            this.remove_item_file.Text = "remove item file";
            this.remove_item_file.UseVisualStyleBackColor = true;
            this.remove_item_file.Click += new System.EventHandler(this.remove_item_file_Click);
            // 
            // remove_file_button
            // 
            this.remove_file_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_file_button.Location = new System.Drawing.Point(287, 198);
            this.remove_file_button.Name = "remove_file_button";
            this.remove_file_button.Size = new System.Drawing.Size(205, 83);
            this.remove_file_button.TabIndex = 3;
            this.remove_file_button.Text = "remove file button";
            this.remove_file_button.UseVisualStyleBackColor = true;
            this.remove_file_button.Click += new System.EventHandler(this.remove_file_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(591, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 304);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 519);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.remove_file_button);
            this.Controls.Add(this.remove_item_file);
            this.Controls.Add(this.btn_read_the_file);
            this.Controls.Add(this.btn_create_the_file);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_create_the_file;
        private System.Windows.Forms.Button btn_read_the_file;
        private System.Windows.Forms.Button remove_item_file;
        private System.Windows.Forms.Button remove_file_button;
        private System.Windows.Forms.ListBox listBox1;
    }
}

