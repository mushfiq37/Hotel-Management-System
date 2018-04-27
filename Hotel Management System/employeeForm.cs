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

namespace Hotel_Management_System
{
    public partial class employeeForm : Form
    {
        
        public employeeForm()
        {
            InitializeComponent();
            
        }


        private void addNewGuest_Click(object sender, EventArgs e)
        {
            new NewGuest().Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // labelInfo.Text = employeeForm.
            global.checkOut = 0;
        }

        private void guestListButton_Click(object sender, EventArgs e)
        {
            new GuestList().Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
                global.mngr = 0;
                global.rcptnst = 0;
                new Login().Show();
                this.Hide();
        
        }

        private void buttonRoomInfo_Click(object sender, EventArgs e)
        {
            new RoomInfo().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new RegisterEvent().Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new eventList().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new roomStatus().Show();
            this.Hide();
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            global.checkOut = 1;
            this.Hide();
            new GuestList().Show();
        }


    }
}
