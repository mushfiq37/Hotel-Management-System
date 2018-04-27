using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class NewGuest : Form
    {
        public NewGuest()
        {
            InitializeComponent();
                   
        }

        private void addGuestButton_Click(object sender, EventArgs e)
        {

            string name, address, contact, date;
            int age, roomNo;

            name = nameTextbox.Text;
            age = int.Parse(ageTextbox.Text);
            contact = contactTextbox.Text;
            address = addressTextbox.Text;
            DateTime dateTime = DateTime.Now;
            date = dateTime.ToString();
            roomNo = int.Parse(roomNoText.Text);
          

            try
            {
                string connectionstring = "datasource=localhost;port=3306;username=root;password=;";

                using (MySqlConnection myConn = new MySqlConnection(connectionstring))
                {
                    myConn.Open();
                    string qurey = "INSERT INTO `hotel_management_db`.`guest` (`name`, `age`, `address`, `contactNo`, `roomNo`,`Check-in`, `Check_out`) VALUES ('" + name + "', " + age + ", '" + address + "','" + contact + "', " + roomNo + ",'" + date + "', 'not yet')";
                    MySqlCommand cmd = new MySqlCommand(qurey, myConn);
                    cmd.ExecuteReader();
                    myConn.Close();

                    myConn.Open();
                    string query1 = "Update hotel_management_db.roominfo SET availability = '1' where roomNo = '" + roomNo + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, myConn);
                    cmd1.ExecuteReader();
                    myConn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Guest successfully added...");
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


        private void NewGuest_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void contactTextbox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
