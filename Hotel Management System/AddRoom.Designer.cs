namespace Hotel_Management_System
{
    partial class AddRoom
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
            this.label9 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addRoomBtn = new System.Windows.Forms.Button();
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.costTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomTypeAddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.roomTypeDesTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.roomTypeTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gabriola", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(205, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 35);
            this.label9.TabIndex = 53;
            this.label9.Text = "Add Room Information";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::Hotel_Management_System.Properties.Resources.images;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 42);
            this.backButton.TabIndex = 54;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 275);
            this.tabControl1.TabIndex = 55;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.roomTypeTextBox);
            this.tabPage1.Controls.Add(this.roomTypeAddBtn);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.roomTypeDesTextBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Room Type";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.addRoomBtn);
            this.tabPage2.Controls.Add(this.roomTypeComboBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.costTextbox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.roomNoTextBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Rooms";
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomBtn.Location = new System.Drawing.Point(20, 194);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Size = new System.Drawing.Size(526, 39);
            this.addRoomBtn.TabIndex = 88;
            this.addRoomBtn.Text = "Add Room";
            this.addRoomBtn.UseVisualStyleBackColor = true;
            this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.Location = new System.Drawing.Point(257, 41);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(145, 21);
            this.roomTypeComboBox.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 77;
            this.label3.Text = "Cost: ";
            // 
            // costTextbox
            // 
            this.costTextbox.Location = new System.Drawing.Point(257, 131);
            this.costTextbox.Name = "costTextbox";
            this.costTextbox.Size = new System.Drawing.Size(145, 20);
            this.costTextbox.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 75;
            this.label2.Text = "Room No:";
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.Location = new System.Drawing.Point(257, 87);
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(145, 20);
            this.roomNoTextBox.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "Room Type:";
            // 
            // roomTypeAddBtn
            // 
            this.roomTypeAddBtn.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeAddBtn.Location = new System.Drawing.Point(21, 182);
            this.roomTypeAddBtn.Name = "roomTypeAddBtn";
            this.roomTypeAddBtn.Size = new System.Drawing.Size(526, 39);
            this.roomTypeAddBtn.TabIndex = 95;
            this.roomTypeAddBtn.Text = "Add Room Type";
            this.roomTypeAddBtn.UseVisualStyleBackColor = true;
            this.roomTypeAddBtn.Click += new System.EventHandler(this.roomTypeAddBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 90;
            this.label5.Text = "Description:";
            // 
            // roomTypeDesTextBox
            // 
            this.roomTypeDesTextBox.Location = new System.Drawing.Point(131, 67);
            this.roomTypeDesTextBox.Multiline = true;
            this.roomTypeDesTextBox.Name = "roomTypeDesTextBox";
            this.roomTypeDesTextBox.Size = new System.Drawing.Size(403, 94);
            this.roomTypeDesTextBox.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 89;
            this.label6.Text = "Room Type:";
            // 
            // roomTypeTextBox
            // 
            this.roomTypeTextBox.Location = new System.Drawing.Point(131, 21);
            this.roomTypeTextBox.Name = "roomTypeTextBox";
            this.roomTypeTextBox.Size = new System.Drawing.Size(173, 20);
            this.roomTypeTextBox.TabIndex = 96;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 337);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRoom";
            this.Load += new System.EventHandler(this.AddRoom_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addRoomBtn;
        private System.Windows.Forms.ComboBox roomTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox costTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomNoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button roomTypeAddBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox roomTypeDesTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox roomTypeTextBox;
    }
}