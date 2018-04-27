using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            global.mngr = 0;
            global.rcptnst = 0;
            new Login().Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRoomInfo_Click(object sender, EventArgs e)
        {
            new RoomInfo().Show();
            this.Hide();
        }

        private void addNewGuest_Click(object sender, EventArgs e)
        {
            new NewGuest().Show();
            this.Hide();
        }

        private void guestListButton_Click(object sender, EventArgs e)
        {
            new GuestList().Show();
        //    this.Hide();
        }

        private void registerEvent_Click(object sender, EventArgs e)
        {
            new RegisterEvent().Show();
            this.Close();
        }

        private void eventList_Click(object sender, EventArgs e)
        {
            new eventList().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new roomStatus().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EmployeInfo().Show();
            this.Hide();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            global.checkOut = 0;
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            new AddEmployee().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AddRoom().Show();
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
