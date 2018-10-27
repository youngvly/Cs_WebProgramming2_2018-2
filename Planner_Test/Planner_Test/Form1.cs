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
        int mm = 0;
        int mov;
        int movX;
        int movY;

        public Hello()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255,255,243);
            
        }

        private void TodoButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 243);

        }

        private void MonthButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 243);

        }

        private void APButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 243);

        }
    }
}
