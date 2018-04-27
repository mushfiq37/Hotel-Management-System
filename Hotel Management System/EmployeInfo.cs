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
    public partial class EmployeInfo : Form
    {
        public EmployeInfo()
        {
            InitializeComponent();
        }

        private void EmployeInfo_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;";
            string query = "select * from `hotel_management_db`.`employee`";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    employeDataGridView.DataSource = ds.Tables[0];
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
            else if(global.rcptnst == 1)
            {
                new employeeForm().Show();
                this.Hide();
            }

        }
    }
}
