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

public class global
{
    public static Int32 mngr = 0;
    public static Int32 rcptnst = 0;
    public static Int32 checkOut = 0;
    public static Int32 roomNum = 0;
    public static String name;
    public static String checkIn;
    public static String contactNum;
    public static Int32 cost;
}

namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string name = userNameText.Text;
            string pass = passText.Text;
            string query;

            try
            {
                string conn = "datasource=localhost;port=3306;username=root;password=;";
                MySqlConnection myConn = new MySqlConnection(conn);

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                //       myDataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM hotel_management_db.login", myConn);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();

                if (managerCheckBox.Checked == true)
                {

                    query = "select user_name , password, Designation from hotel_management_db.login where user_name = '" + name + "' && Designation = 'Manager';";
                    MySqlCommand cmd = new MySqlCommand(query, myConn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count++;
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Wrong username or password!!!!");
                    }
                    else
                    {
                        global.mngr = 1;
                        new ManagerForm().Show();
                        this.Hide();
                    }

                }
                else if (employeeCheckBox.Checked == true)
                {
                    query = "select user_name , password, Designation from hotel_management_db.login where user_name = '" + name + "' && Designation = 'Receptionist';";
                    MySqlCommand cmd = new MySqlCommand(query, myConn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count++;
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Wrong username or password!!!!");
                    }
                    else
                    {
                        //     employeeForm emp = new employeeForm(userNameText.Text);
                        global.rcptnst = 1;
                        new employeeForm().Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Choose your designation.....");
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }
    }
}
