namespace Hotel_Management_System
{
    partial class RoomInfo
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
            this.label3 = new System.Windows.Forms.Label();
            this.roomInfoGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomInfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gabriola", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(190, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 35);
            this.label3.TabIndex = 13;
            this.label3.Text = "Information of Rooms in Details";
            // 
            // roomInfoGridView
            // 
            this.roomInfoGridView.AllowUserToAddRows = false;
            this.roomInfoGridView.AllowUserToDeleteRows = false;
            this.roomInfoGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.roomInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomInfoGridView.Location = new System.Drawing.Point(12, 38);
            this.roomInfoGridView.Name = "roomInfoGridView";
            this.roomInfoGridView.ReadOnly = true;
            this.roomInfoGridView.Size = new System.Drawing.Size(565, 295);
            this.roomInfoGridView.TabIndex = 14;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::Hotel_Management_System.Properties.Resources.images;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(5, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 33);
            this.backButton.TabIndex = 15;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 345);
            this.Controls.Add(this.roomInfoGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomInfo";
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomInfoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView roomInfoGridView;
        private System.Windows.Forms.Button backButton;
    }
}