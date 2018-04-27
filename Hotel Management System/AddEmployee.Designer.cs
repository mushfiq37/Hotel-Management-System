namespace Hotel_Management_System
{
    partial class AddEmployee
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
            this.backButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ageTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.desigComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::Hotel_Management_System.Properties.Resources.images;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 42);
            this.backButton.TabIndex = 37;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gabriola", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(178, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 35);
            this.label9.TabIndex = 36;
            this.label9.Text = "Add Employee Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Name:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(112, 68);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(191, 20);
            this.nameTextbox.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(112, 116);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(191, 40);
            this.addressTextBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Age:";
            // 
            // ageTextbox
            // 
            this.ageTextbox.Location = new System.Drawing.Point(432, 71);
            this.ageTextbox.Name = "ageTextbox";
            this.ageTextbox.Size = new System.Drawing.Size(145, 20);
            this.ageTextbox.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Sex:";
            // 
            // sexComboBox
            // 
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexComboBox.Location = new System.Drawing.Point(432, 118);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(145, 21);
            this.sexComboBox.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Contact NO:";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(112, 178);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(191, 20);
            this.contactTextBox.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = "Designation:";
            // 
            // desigComboBox
            // 
            this.desigComboBox.FormattingEnabled = true;
            this.desigComboBox.Items.AddRange(new object[] {
            "Manager",
            "Receptionist",
            "Waiter",
            "Sweeper",
            "Cook",
            "Cleaner",
            "Security Guard"});
            this.desigComboBox.Location = new System.Drawing.Point(432, 177);
            this.desigComboBox.Name = "desigComboBox";
            this.desigComboBox.Size = new System.Drawing.Size(145, 21);
            this.desigComboBox.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Shift:";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(112, 225);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(143, 20);
            this.fromTextBox.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 18);
            this.label8.TabIndex = 51;
            this.label8.Text = "to";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(308, 225);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(136, 20);
            this.toTextBox.TabIndex = 50;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.Location = new System.Drawing.Point(13, 270);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(567, 39);
            this.addEmployeeButton.TabIndex = 52;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 321);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.desigComboBox);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ageTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ageTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox desigComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Button addEmployeeButton;
    }
}