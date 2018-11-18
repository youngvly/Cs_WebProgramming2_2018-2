using Planner_Test.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner_Test
{
    public partial class Hello : Form
    {
        public static Users logined = new Users();

        /*public Hello()
        {
            InitializeComponent();
        }*/
        public Hello(Users user)
        {
            InitializeComponent(user);
            if (user.Userid > 0)
            {
                logined.Id = user.Id;
                logined.Userid = user.Userid;
                usernameText.Text = logined.Id;
            }
            
        }
        private void resetButton()
        {
            MainButton.BackColor = Color.FromArgb(34, 31, 58);
            TodoButton.BackColor = Color.FromArgb(34, 31, 58);
            MonthButton.BackColor = Color.FromArgb(34, 31, 58);
            APButton.BackColor = Color.FromArgb(34, 31, 58);

            MainButton.ForeColor = Color.FromArgb(255, 255, 243);
            TodoButton.ForeColor = Color.FromArgb(255, 255, 243);
            MonthButton.ForeColor = Color.FromArgb(255, 255, 243);
            APButton.ForeColor = Color.FromArgb(255, 255, 243);
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            resetButton();
            MainButton.BackColor = Color.FromArgb(255,255,243);
            MainButton.ForeColor = Color.FromArgb(34, 31, 58);
            mainUserControl.BringToFront();
            
        }

        private void TodoButton_Click(object sender, EventArgs e)
        {
            resetButton();

            TodoButton.BackColor = Color.FromArgb(255, 255, 243);
            TodoButton.ForeColor = Color.FromArgb(34, 31, 58);
            todoControl1.BringToFront();

        }

        private void MonthButton_Click(object sender, EventArgs e)
        {
            resetButton();

            MonthButton.BackColor = Color.FromArgb(255, 255, 243);
            MonthButton.ForeColor = Color.FromArgb(34, 31, 58);
            monthControl1.BringToFront();

        }

        private void APButton_Click(object sender, EventArgs e)
        {
            resetButton();

            APButton.BackColor = Color.FromArgb(255, 255, 243);
            APButton.ForeColor = Color.FromArgb(34, 31, 58);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthControl1_Load(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            logined = new Users();
            loginForms loginforms = new loginForms();
            loginforms.Show();
            this.Hide();
        }
    }
}
