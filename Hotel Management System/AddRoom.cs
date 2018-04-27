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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            roomTypeCombo();
        }

        private void roomTypeAddBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn;

            string roomType, description;

            roomType = roomTypeTextBox.Text;
            description = roomTypeDesTextBox.Text;

            try
            {
                string connectionstring = "datasource=localhost;port=3306;username=root;password=;";
                myConn = new MySqlConnection(connectionstring);

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();

                string qurey = "INSERT INTO `hotel_management_db`.`roomtype` ( Type, Description) VALUES ('" + roomType + "','" + description + "')";
                MySqlCommand cmd = new MySqlCommand(qurey, myConn);
                //    MySqlDataReader reader;
                cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Room Type added successfully....");
            this.Close();
            new ManagerForm().Show();
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn;

            int roomNo, cost;
            string type;

            type = roomTypeComboBox.Text;
            roomNo = int.Parse(roomNoTextBox.Text);
            cost = int.Parse(costTextbox.Text);

            try
            {
                string connectionstring = "datasource=localhost;port=3306;username=root;password=;";
                myConn = new MySqlConnection(connectionstring);

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();

                string qurey = "INSERT INTO `hotel_management_db`.`roominfo` ( room_type, roomNo, cost, availability) VALUES ((select roomType_Id from hotel_management_db.roomtype where Type = '"+type+"'),'" + roomNo + "', '"+cost+"', '0')";
                MySqlCommand cmd = new MySqlCommand(qurey, myConn);
                //    MySqlDataReader reader;
                cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Room added successfully....");
            this.Close();
            new ManagerForm().Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new ManagerForm().Show();
        }

        public void roomTypeCombo()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=;";
                string query = "select Type from hotel_management_db.roomtype";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    roomTypeComboBox.Items.Add(reader.GetString("Type"));
                }

            }
            catch (Exception ex)
            {

            }
        }

    }
}
