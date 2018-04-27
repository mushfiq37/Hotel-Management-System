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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }


        private void registerButon_Click(object sender, EventArgs e)
        {
            string name = null;
            string pass = null;
            string designation = null;
            string masterPass = "HMR";

            if (userNameText.Text == "" || passText.Text == "")
                MessageBox.Show("One of the required field is null...");

            else if (passText.TextLength < 4)
                MessageBox.Show("Use atleast 4 digits as Password...");

            else if(masterText.Text == masterPass)
            {
                name = userNameText.Text;
                pass = passText.Text;
                designation = designationComboBox.Text;
                MySqlConnection myConn;

                try
                {
                    string connectionstring = "datasource=localhost;port=3306;username=root;password=;";
                    myConn = new MySqlConnection(connectionstring);

                    MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                    myDataAdapter.SelectCommand = new MySqlCommand("select * hotel_management_db.login", myConn);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(myDataAdapter);
                    myConn.Open();

                    string qurey = "INSERT INTO `hotel_management_db`.`login` (`user_name`, `password`, `Designation`) VALUES ('" + name + "', md5('" + pass + "'), '" + designation + "');";
                    MySqlCommand cmd = new MySqlCommand(qurey, myConn);             
                    cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }

                MessageBox.Show("Successfully Registered...");
                new Login().Show();
                this.Hide();
               
            }

            else
            {
                MessageBox.Show("Enter Master key!!!!");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();

        }

    }
}
