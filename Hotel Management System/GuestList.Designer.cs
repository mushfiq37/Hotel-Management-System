namespace Hotel_Management_System
{
    partial class GuestList
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
            this.components = new System.ComponentModel.Container();
            this.hotel_Mangement_SystemDataSet = new Hotel_Management_System.Hotel_Mangement_SystemDataSet();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsTableAdapter = new Hotel_Management_System.Hotel_Mangement_SystemDataSetTableAdapters.GuestsTableAdapter();
            this.tableAdapterManager = new Hotel_Management_System.Hotel_Mangement_SystemDataSetTableAdapters.TableAdapterManager();
            this.backButton = new System.Windows.Forms.Button();
            this.guestsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Mangement_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hotel_Mangement_SystemDataSet
            // 
            this.hotel_Mangement_SystemDataSet.DataSetName = "Hotel_Mangement_SystemDataSet";
            this.hotel_Mangement_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataMember = "Guests";
            this.guestsBindingSource.DataSource = this.hotel_Mangement_SystemDataSet;
            // 
            // guestsTableAdapter
            // 
            this.guestsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GuestsTableAdapter = this.guestsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Hotel_Management_System.Hotel_Mangement_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(78, 33);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // guestsDataGridView
            // 
            this.guestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestsDataGridView.Location = new System.Drawing.Point(12, 42);
            this.guestsDataGridView.Name = "guestsDataGridView";
            this.guestsDataGridView.Size = new System.Drawing.Size(843, 353);
            this.guestsDataGridView.TabIndex = 11;
            this.guestsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guestsDataGridView_CellClick);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(545, 9);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(183, 20);
            this.searchTextbox.TabIndex = 12;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(734, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 33);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // GuestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 406);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.guestsDataGridView);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestList";
            this.Load += new System.EventHandler(this.GuestList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Mangement_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Hotel_Mangement_SystemDataSet hotel_Mangement_SystemDataSet;
        private System.Windows.Forms.BindingSource guestsBindingSource;
        private Hotel_Mangement_SystemDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter;
        private Hotel_Mangement_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView guestsDataGridView;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Button searchButton;
    }
}