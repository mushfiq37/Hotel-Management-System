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
    public partial class GuestList : Form
    {
        public GuestList()
        {
            InitializeComponent();
        }

        int cost;
    
        private void GuestList_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;";

            if (global.checkOut == 1)
            {
                string query = "select * from `hotel_management_db`.`guest` where Check_out = 'not yet'";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        guestsDataGridView.DataSource = ds.Tables[0];
                    }
                }
            }
            else
            {
                string query = "select * from `hotel_management_db`.`guest`";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        guestsDataGridView.DataSource = ds.Tables[0];
                    }
                }
            }

        }


        //Back Button
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

        //Search portion

        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
              
        private void searchButton_Click(object sender, EventArgs e)
        {
            string text = searchTextbox.Text;

            string connectionString = "datasource=localhost;port=3306;username=root;password=;"; 
            MySqlConnection connection = new MySqlConnection(connectionString);

            if (searchTextbox.Text != null)
            {
                string query = "select * from `hotel_management_db`.`guest` where name = '"+text+"'";
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                guestsDataGridView.DataSource = table;

            }
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guestsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (global.checkOut == 1)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null)
                    return;
                if (dgv.CurrentRow.Selected)
                {
                    foreach (DataGridViewRow row in guestsDataGridView.SelectedRows)
                    {
                        global.name = row.Cells[1].Value.ToString();
                        global.contactNum = row.Cells[4].Value.ToString();
                        global.roomNum = int.Parse(row.Cells[5].Value.ToString());
                        global.checkIn = row.Cells[6].Value.ToString();

                    }

                    try
                    {
                        string connectionstring = "datasource=localhost;port=3306;username=root;password=;";

                        using (MySqlConnection myConn = new MySqlConnection(connectionstring))
                        {
                            myConn.Open();
                            string qurey = "select cost from hotel_management_db.roominfo where roomNo = '" + global.roomNum + "'";
                            MySqlCommand cmd = new MySqlCommand(qurey, myConn);
                            global.cost = (int)cmd.ExecuteScalar();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    


                    this.Hide();
                    new CheckOut().Show();
                }
            }
        }


    }
}
