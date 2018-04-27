using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class eventList : Form
    {
        public eventList()
        {
            InitializeComponent();
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

        private void eventList_Load(object sender, EventArgs e)
        {

            string connectionString = "datasource=localhost;port=3306;username=root;password=;";
            string query = "select * from `hotel_management_db`.`registerEvent`"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
