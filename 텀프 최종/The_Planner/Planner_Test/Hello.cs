using The_Planner.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Planner
{
    public partial class Hello : Form
    {
        public static Users logined = new Users();
        private Point mCurrentPosition = new Point(0, 0);

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
            System.Windows.Forms.Application.Exit();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                this.Location.X + (mCurrentPosition.X + e.X),
                this.Location.Y + (mCurrentPosition.Y + e.Y));
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mCurrentPosition = new Point(-e.X, -e.Y);
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
