using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Planner.domain;
using The_Planner.DBControl;

namespace The_Planner
{
    public partial class UserControl1 : UserControl
    {
        Users user = new Users();
        WeekPlanDBService wpdm;
        PlanDBService pdm;
        public UserControl1(Users u)
        {
            InitializeComponent();
            TodayTextBox.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 오늘");
            user = u;
            wpdm = new MakeConnection(u).makeWeekPlanDBModel();
            pdm = new MakeConnection(u).makePlanDBModel();
            showPlan();
        }

        private void addFixedPlanButton_Click(object sender, EventArgs e)
        {
            weekPlanForm weekplanForm = new weekPlanForm(user,this);
            weekplanForm.Show();
        }

        public void showPlan()
        {
            List<Label> labels = new List<Label>
            {
                label25, label26, label27 , label28, label29, label30, label31, label32 , label33,
                label34, label35, label36, label37, label38, label39, label40 , label41, label42,
                label43 , label44, label45, label46, label47, label48
            };
            List<Color> colors = new List<Color>
            {
                Color.Aqua, Color.BlueViolet, Color.Coral, Color.Honeydew,Color.AliceBlue
            };
            foreach (Label l in labels)
            {
                l.Text = "";
            }

            DataTable dt = wpdm.SelectPlanByWeekDay(DateTime.Now.DayOfWeek.ToString());
            DataTable dtMonth = pdm.SelectPlanByDateTime(DateTime.Now);
            foreach (DataRow row in dt.Rows)
            {
                int startHour = int.Parse(row["startTime"].ToString().Substring(0, 2));
                int endHour = int.Parse(row["endTime"].ToString().Substring(0, 2));
                Color c = colors.ElementAt(startHour % colors.Count);
                for (int i=startHour; i<endHour; i++)
                {
                    labels[i].Text = row["title"].ToString();
                    labels[i].BackColor = c;
                }
            }
            foreach(DataRow row in dtMonth.Rows)
            {
                //Console.WriteLine(row["startDate"].ToString());
                DateTime tempDate;
                DateTime.TryParse(row["startDate"].ToString(), out tempDate);
                int startHour = tempDate.Hour;
                DateTime.TryParse(row["endDate"].ToString(), out tempDate);
                int endHour = tempDate.Hour;

                //if (row["startDate"].ToString().Contains("오후"))
                //{
                //    startHour += 12;
                //    endHour += 12;
                //}
                Color c = colors.ElementAt(startHour % colors.Count);
                for (int i = startHour; i < endHour; i++)
                {
                    labels[i].Text += row["title"].ToString();
                    labels[i].BackColor = c;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            showPlan();
        }
    }
}
