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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            nameTxtBox.Text = global.name;
            contactTxtBox.Text = global.contactNum;
            roomNoTxtBox.Text = global.roomNum.ToString();
            checkedInTxtBox.Text = global.checkIn;
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

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            int total, days;
            double discount;
            string date;

            days = int.Parse(stayNumericUpDown.Value.ToString());
            discount = int.Parse(discountNumericUpDown2.Value.ToString());

            total = global.cost * days;
            discount = total * (discount / 100);
            total = total - (int)discount;

            DateTime dateTime = DateTime.Now;
            date = dateTime.ToString();

            try
            {
                string connectionstring = "datasource=localhost;port=3306;username=root;password=;";

                using (MySqlConnection myConn = new MySqlConnection(connectionstring))
                {
                    myConn.Open();
                    string qurey = "Update hotel_management_db.roominfo SET availability = '0' where roomNo = '" + global.roomNum + "'";
                    MySqlCommand cmd = new MySqlCommand(qurey, myConn);
                    cmd.ExecuteReader();
                    myConn.Close();

                    myConn.Open();
                    string qurey1 = "Update hotel_management_db.guest SET Check_out = '" + date + "' where name = '" + global.name + "' and contactNo = '" + global.contactNum + "'";
                    MySqlCommand cmd1 = new MySqlCommand(qurey1, myConn);
                    cmd1.ExecuteReader();
                    myConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Your total Bill is: " + total);

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
