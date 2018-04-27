namespace Hotel_Management_System
{
    partial class Login
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
            this.managerCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.passText = new System.Windows.Forms.TextBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // managerCheckBox
            // 
            this.managerCheckBox.AutoSize = true;
            this.managerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.managerCheckBox.Font = new System.Drawing.Font("Gabriola", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.managerCheckBox.Location = new System.Drawing.Point(46, 153);
            this.managerCheckBox.Name = "managerCheckBox";
            this.managerCheckBox.Size = new System.Drawing.Size(94, 39);
            this.managerCheckBox.TabIndex = 49;
            this.managerCheckBox.Text = "Manager";
            this.managerCheckBox.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gabriola", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 39);
            this.label4.TabIndex = 48;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(303, 207);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(80, 33);
            this.loginButton.TabIndex = 47;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // regButton
            // 
            this.regButton.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regButton.Location = new System.Drawing.Point(188, 207);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(109, 33);
            this.regButton.TabIndex = 46;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // passText
            // 
            this.passText.Font = new System.Drawing.Font("Gabriola", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passText.Location = new System.Drawing.Point(117, 114);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(266, 33);
            this.passText.TabIndex = 45;
            this.passText.UseSystemPasswordChar = true;
            // 
            // userNameText
            // 
            this.userNameText.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameText.Location = new System.Drawing.Point(117, 59);
            this.userNameText.Multiline = true;
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(266, 36);
            this.userNameText.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gabriola", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 39);
            this.label3.TabIndex = 43;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gabriola", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 39);
            this.label2.TabIndex = 42;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "Verify yourself....";
            // 
            // employeeCheckBox
            // 
            this.employeeCheckBox.AutoSize = true;
            this.employeeCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.employeeCheckBox.Font = new System.Drawing.Font("Gabriola", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeCheckBox.Location = new System.Drawing.Point(222, 153);
            this.employeeCheckBox.Name = "employeeCheckBox";
            this.employeeCheckBox.Size = new System.Drawing.Size(120, 39);
            this.employeeCheckBox.TabIndex = 50;
            this.employeeCheckBox.Text = "Receptionist";
            this.employeeCheckBox.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Management_System.Properties.Resources.security;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(403, 260);
            this.Controls.Add(this.employeeCheckBox);
            this.Controls.Add(this.managerCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox managerCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox employeeCheckBox;
    }
}