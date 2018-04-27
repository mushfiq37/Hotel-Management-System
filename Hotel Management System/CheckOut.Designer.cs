namespace Hotel_Management_System
{
    partial class CheckOut
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contactTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomNoTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedInTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.stayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.discountNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.stayNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::Hotel_Management_System.Properties.Resources.images;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(4, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 42);
            this.backButton.TabIndex = 56;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gabriola", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(104, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 35);
            this.label9.TabIndex = 55;
            this.label9.Text = "Check Out Information";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Enabled = false;
            this.nameTxtBox.Location = new System.Drawing.Point(157, 107);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.ReadOnly = true;
            this.nameTxtBox.Size = new System.Drawing.Size(173, 20);
            this.nameTxtBox.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 97;
            this.label6.Text = "Name:";
            // 
            // contactTxtBox
            // 
            this.contactTxtBox.Enabled = false;
            this.contactTxtBox.Location = new System.Drawing.Point(157, 149);
            this.contactTxtBox.Name = "contactTxtBox";
            this.contactTxtBox.ReadOnly = true;
            this.contactTxtBox.Size = new System.Drawing.Size(173, 20);
            this.contactTxtBox.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 99;
            this.label1.Text = "Contact No:";
            // 
            // roomNoTxtBox
            // 
            this.roomNoTxtBox.Enabled = false;
            this.roomNoTxtBox.Location = new System.Drawing.Point(157, 192);
            this.roomNoTxtBox.Name = "roomNoTxtBox";
            this.roomNoTxtBox.ReadOnly = true;
            this.roomNoTxtBox.Size = new System.Drawing.Size(173, 20);
            this.roomNoTxtBox.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 101;
            this.label2.Text = "Room No:";
            // 
            // checkedInTxtBox
            // 
            this.checkedInTxtBox.Enabled = false;
            this.checkedInTxtBox.Location = new System.Drawing.Point(157, 234);
            this.checkedInTxtBox.Name = "checkedInTxtBox";
            this.checkedInTxtBox.ReadOnly = true;
            this.checkedInTxtBox.Size = new System.Drawing.Size(173, 20);
            this.checkedInTxtBox.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 103;
            this.label3.Text = "Checked In:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 105;
            this.label4.Text = "Stayed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 107;
            this.label5.Text = "days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 108;
            this.label7.Text = "Discount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 18);
            this.label8.TabIndex = 110;
            this.label8.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 18);
            this.label10.TabIndex = 111;
            this.label10.Text = "Payment:";
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Bkash"});
            this.paymentComboBox.Location = new System.Drawing.Point(157, 363);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(173, 21);
            this.paymentComboBox.TabIndex = 112;
            // 
            // checkOutButton
            // 
            this.checkOutButton.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutButton.Location = new System.Drawing.Point(12, 432);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(367, 39);
            this.checkOutButton.TabIndex = 113;
            this.checkOutButton.Text = "Check-Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // stayNumericUpDown
            // 
            this.stayNumericUpDown.Location = new System.Drawing.Point(157, 281);
            this.stayNumericUpDown.Name = "stayNumericUpDown";
            this.stayNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.stayNumericUpDown.TabIndex = 114;
            // 
            // discountNumericUpDown2
            // 
            this.discountNumericUpDown2.Location = new System.Drawing.Point(157, 320);
            this.discountNumericUpDown2.Name = "discountNumericUpDown2";
            this.discountNumericUpDown2.Size = new System.Drawing.Size(65, 20);
            this.discountNumericUpDown2.TabIndex = 115;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 483);
            this.Controls.Add(this.discountNumericUpDown2);
            this.Controls.Add(this.stayNumericUpDown);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.paymentComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedInTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomNoTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contactTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stayNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contactTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomNoTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox checkedInTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.NumericUpDown stayNumericUpDown;
        private System.Windows.Forms.NumericUpDown discountNumericUpDown2;
    }
}