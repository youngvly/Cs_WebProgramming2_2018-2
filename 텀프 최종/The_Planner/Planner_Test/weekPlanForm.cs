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
    public partial class weekPlanForm : Form
    {
        private WeekPlanDBService wpdm;
        private WeekPlan weekplan = new WeekPlan();
        private string[] hourArray = new string[24];
        private UserControl1 weekControl;
        public weekPlanForm(Users user)
        {
            wpdm = new MakeConnection(user).makeWeekPlanDBModel();
            weekplan.userId = user.Userid;
            InitializeComponent();
            for (int i=0; i<24; i++)
            {
                hourArray[i] = string.Format("{0:D2}", i) + ":00";
            }
            foreach (var hour in hourArray)
            {
                startHourComboBox.Items.Add(hour);
                endHourComboBox.Items.Add(hour);
            }
        }
        public weekPlanForm(Users user,UserControl1 weekControl)
        {
            this.weekControl = weekControl;
            wpdm = new MakeConnection(user).makeWeekPlanDBModel();
            weekplan.userId = user.Userid;
            InitializeComponent();
            for (int i = 0; i < 24; i++)
            {
                hourArray[i] = string.Format("{0:D2}", i) + ":00";
            }
            foreach (var hour in hourArray)
            {
                startHourComboBox.Items.Add(hour);
                endHourComboBox.Items.Add(hour);
            }
        }
        private bool checkHour()
        {
            return true;
        }
        private void button1_Click(object sender, EventArgs e)          //add
        {
            if (!checkHour())
            {
                MessageBox.Show("날짜를 다시 선택해주세요.");
            }
            else
            {
                weekplan.title = textBox1.Text;
                weekplan.contents = textBox2.Text;
                weekplan.startTime = startHourComboBox.Text.ToString();
                weekplan.endTime = endHourComboBox.Text.ToString();
                wpdm.AddWeekPlan(weekplan);
                weekControl.showPlan();
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dayButton_Click(object sender, EventArgs e)          //add
        {
            Button[] buttons = new Button[]
            {
                mondayButton , tuesdayButton,button4,button5,button6,button7,button8
            };
            Button selectedButton = buttons.FirstOrDefault(b => sender.Equals(b));

            weekplan.dayOfWeek = selectedButton.Text;
        }
    }
}
