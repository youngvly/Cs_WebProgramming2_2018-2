using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace The_Planner
{
    public partial class signupControls : UserControl
    {
        public signupControls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=Young;Initial Catalog=plan_db;Integrated Security=True";
            string commands = "SELECT * FROM users WHERE id = '" + idBox.Text + "'";
            SqlConnection con = new SqlConnection(connetionString);
            SqlDataAdapter dap = new SqlDataAdapter(commands, con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("이미 존재하는 ID입니다.");
            }
            else
            {
                commands = "INSERT INTO users(id,pass,email) VALUES('" + idBox.Text + "','" + passBox.Text + "','" + emailBox.Text + "')";
                dap = new SqlDataAdapter(commands, con);
                MessageBox.Show("회원가입 완료");
                this.Visible = false;
            }


            dap.Fill(dt);
        }
    }
}
