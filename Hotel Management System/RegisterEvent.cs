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
    public partial class RegisterEvent : Form
    {
        public RegisterEvent()
        {
            InitializeComponent();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

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

        private void label4_Click(object sender, EventArgs e)
        {
   

        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn;

            string eventName, eventCat, strtTime, endTime, eventHolder, contactNo, address, nmbrOfGuest, food, decoration;
            DateTimePicker date = dateTimePicker;
            string eventDate = date.ToString();
            string strt = timeCombo.Text;
            string end = timeCombo2.Text;

            eventName = EventNameTextbox.Text;
            eventCat = eventCatComboBox.Text;
            strtTime = strtTxtBox.Text;
            endTime = endTxtBox.Text;
            eventHolder = eventHolderTxtBox.Text;
            contactNo = contactTxtBox.Text;
            address = addressTxtBox.Text;
            nmbrOfGuest = nmbrOfGstsText.Text;
            food = foodTextBox.Text;
            decoration = decTextBox.Text;
            string caterer = cateringComboBox.ToString();

            try
            {
                string connectionstring = "datasource=localhost;port=3306;username=root;password=;";
                myConn = new MySqlConnection(connectionstring);

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("select * hotel_management.registerEvent", myConn);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();

                string qurey = "INSERT INTO `hotel_management_db`.`registerEvent` (`Event Name`, `Event Catagory`, `Event Date`, `Event Start Time`, `Event End Time`, `Event Holder`, `Contact No`, `Address`, `Number Of Guests`, `Catering`, `Food`, `Decoration`) VALUES ('" + eventName + "','" + eventCat + "','" + eventDate + "','" + strtTime + "" + strt + "', '" + endTime + "" + end + "','" + eventHolder + "', '" + contactNo + "', '" + address + "', '" + nmbrOfGuest + "', '" + caterer + "', '" + food + "', '" + decoration + "');";
                MySqlCommand cmd = new MySqlCommand(qurey, myConn);
              //  MySqlDataReader reader;
                cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            new ManagerForm().Show();
            this.Hide();

        }


    }
}
