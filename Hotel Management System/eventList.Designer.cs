namespace Hotel_Management_System
{
    partial class eventList
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.hotel_Mangement_SystemDataSet1 = new Hotel_Management_System.Hotel_Mangement_SystemDataSet();
            this.eventTableAdapterManager = new Hotel_Management_System.Hotel_Mangement_SystemDataSetTableAdapters.TableAdapterManager();
            this.hotel_Mangement_SystemDataSet2 = new Hotel_Management_System.Hotel_Mangement_SystemDataSet();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Mangement_SystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Mangement_SystemDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(13, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 33);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 51);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(865, 331);
            this.dataGridView.TabIndex = 13;
            // 
            // hotel_Mangement_SystemDataSet1
            // 
            this.hotel_Mangement_SystemDataSet1.DataSetName = "Hotel_Mangement_SystemDataSet";
            this.hotel_Mangement_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventTableAdapterManager
            // 
            this.eventTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.eventTableAdapterManager.Connection = null;
            this.eventTableAdapterManager.GuestsTableAdapter = null;
            this.eventTableAdapterManager.UpdateOrder = Hotel_Management_System.Hotel_Mangement_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hotel_Mangement_SystemDataSet2
            // 
            this.hotel_Mangement_SystemDataSet2.DataSetName = "Hotel_Mangement_SystemDataSet";
            this.hotel_Mangement_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gabriola", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(406, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "Event List";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // eventList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "eventList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eventList";
            this.Load += new System.EventHandler(this.eventList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Mangement_SystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Mangement_SystemDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private Hotel_Mangement_SystemDataSet hotel_Mangement_SystemDataSet1;
        private Hotel_Mangement_SystemDataSetTableAdapters.TableAdapterManager eventTableAdapterManager;
        private Hotel_Mangement_SystemDataSet hotel_Mangement_SystemDataSet2;
        private System.Windows.Forms.Label label3;
    }
}