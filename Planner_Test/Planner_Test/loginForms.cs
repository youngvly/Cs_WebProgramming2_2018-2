using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Planner_Test.domain;

namespace Planner_Test
{
    public partial class loginForms : Form
    {
        public loginForms()
        {
            InitializeComponent();
            signupControls1.Visible = false;
        }

        private void loginForms_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void loginBox_Click(object sender, EventArgs e)
        {
            string commands = "SELECT id,userid FROM users WHERE  id = '" + idbox.Text.Trim() + "' AND pass='" + passbox.Text.Trim()+"'";
            /*SqlConnection con = new SqlConnection(
                new SqlConnectionStringBuilder()
                {
                    DataSource = "localhost",
                    InitialCatalog = "plan_db",
                    UserID = "planAdmin",
                    Password = "123456"
                }.ConnectionString
            );*/
            string connetionString = "Data Source=Young;Initial Catalog=plan_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(connetionString);
            SqlDataAdapter dap = new SqlDataAdapter(commands, con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt.Rows.Count >= 1)  //로그인 성공
            {
                this.Hide();
                // Hello hello = new Hello();
                Users logined = new Users();
                logined.Id = dt.Rows[0][0].ToString();
                logined.Userid = (int)dt.Rows[0][1];
                Hello hello = new Hello(logined);
                hello.Show();
                
            }
            else    //로그인실패
            {
                MessageBox.Show("로그인 실패! 아이디와 비밀번호를 확인하세요");
            }
        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signupControls1.BringToFront();
            signupControls1.Visible = true;
        }
    }
}
