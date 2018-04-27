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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn;

            string name, address, contact, sex, designation, from, to;
            int age;

            name = nameTextbox.Text;
            age = int.Parse(ageTextbox.Text);
            contact = contactTextBox.Text;
            address = addressTextBox.Text;
            sex = sexComboBox.Text;
            designation = desigComboBox.Text;
            from = fromTextBox.Text;
            to = toTextBox.Text;

            try
            {
                string connectionstring = "datasource=localhost;port=3306;username=root;password=;";
                myConn = new MySqlConnection(connectionstring);

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
       //         myDataAdapter.SelectCommand = new MySqlCommand("select * hotel_management_db.guests", myConn);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();

                string qurey = "INSERT INTO `hotel_management_db`.`employee` ( Name, Age, Sex, Address, Designation, ContactNo, S_From, S_To) VALUES ('" + name + "','" + age + "','" + sex + "','" + address + "','" + designation + "','" + contact + "','" + from + "','" + to + "')";
                MySqlCommand cmd = new MySqlCommand(qurey, myConn);
                //    MySqlDataReader reader;
                cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Employee added successfully....");
            this.Close();
            new ManagerForm().Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new ManagerForm().Show();
        }

    }
}
