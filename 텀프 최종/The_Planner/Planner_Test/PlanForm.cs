using The_Planner.DBControl;
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
    public partial class PlanForm : Form
    {
        private Plan plan = new Plan();
        private PlanDBService pdm;
        private MonthControl upperMonthControl;
        public PlanForm(Users user,int isfixed)
        {
            pdm = new MakeConnection(user).makePlanDBModel();
            InitializeComponent();

            comboBox1.Items.Add("예약");
            comboBox1.Items.Add("과제");
            comboBox1.Items.Add("여행");
            comboBox1.Items.Add("모임");
            comboBox1.Items.Add("기타");

            plan.isFixed = isfixed;
        }
        public PlanForm(Users user, int isfixed,MonthControl monthControl)
        {
            pdm = new MakeConnection(user).makePlanDBModel();
            InitializeComponent();

            comboBox1.Items.Add("예약");
            comboBox1.Items.Add("과제");
            comboBox1.Items.Add("여행");
            comboBox1.Items.Add("모임");
            comboBox1.Items.Add("기타");

            plan.isFixed = isfixed;
            upperMonthControl = monthControl;
        }

        private bool checkDate()
        {
            int startYear = int.Parse(dateTimePicker1.Value.ToString("yyyy"));
            int endYear = int.Parse(dateTimePicker2.Value.ToString("yyyy"));
            int startMonth = int.Parse(dateTimePicker1.Value.ToString("MM"));
            int endMonth = int.Parse(dateTimePicker2.Value.ToString("MM"));
            int startDay = int.Parse(dateTimePicker1.Value.ToString("dd"));
            int endDay = int.Parse(dateTimePicker2.Value.ToString("dd"));
            if (startYear > endYear)
            {
                return false;
            }else if(startMonth > endMonth){
                return false;
            }else if (startDay > endDay)
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkDate())
            {
                MessageBox.Show("날짜를 다시 선택해주세요.");
            }else
            {
                plan.title = textBox1.Text;
                plan.contents = textBox2.Text;
                plan.subject = comboBox1.Text;
                string temp = dateTimePicker1.Value.ToString("yyyy / MM / dd ") + dateTimePicker3.Value.ToString("HH:mm");
                plan.startDate = DateTime.Parse( temp);
                temp = dateTimePicker2.Value.ToString("yyyy / MM / dd ") + dateTimePicker4.Value.ToString("HH:mm");
                plan.endDate = DateTime.Parse(temp);

                pdm.AddPlan(plan);
                this.Close();
                upperMonthControl.drawPlan();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
