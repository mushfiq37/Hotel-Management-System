using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class RoomInfo : Form
    {
        public RoomInfo()
        {
            InitializeComponent();
        }
        DataTable table;
        private void RoomInfo_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;";
            string query = "select Type as Room_Type,Description from hotel_management_db.roomtype";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    table = new DataTable();
                    adapter.Fill(table);
                    roomInfoGridView.DataSource = table;
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (global.mngr == 1)
            {
                new ManagerForm().Show();
                this.Hide();
            }
            else if (global.rcptnst == 1)
            {
                new employeeForm().Show();
                this.Hide();
            }
        }
    }
}
