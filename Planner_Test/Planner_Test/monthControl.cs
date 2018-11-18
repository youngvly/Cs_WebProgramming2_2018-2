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
using Planner_Test.domain;
using Planner_Test.DBControl;

namespace Planner_Test
{
    public partial class monthControl : UserControl
    {
        int year = int.Parse(DateTime.Now.ToString("yyyy"));
        int month = int.Parse(DateTime.Now.ToString("MM"));
        int day = int.Parse(DateTime.Now.ToString("dd"));
        int startDateindex = 0;
        MakeConnection connection;
        Users user = new Users();

        public monthControl(Users u)
        {
            InitializeComponent();
            connection = new MakeConnection(u);
            user = u;
            drawdate();
            drawPlan();
        }

        private void drawdate()
        {
            yearLabel.Text = year + "년";
            MonthLabel.Text = month + "월";

            Label[] datelist = new Label[] {
                l00,l01,l02,l03,l04,l05,l06,
                l10,l11,l12,l13,l14,l15,l16,
                l20,l21,l22,l23,l24,l25,l26,
                l30,l31,l32,l33,l34,l35,l36,
                l40,l41,l42,l43,l44,l45,l46,
            };
            foreach (Label d in datelist)
            {
                d.Text = "";
            }

            GetCalender gc = new GetCalender(year, month, day);
            string firstDate = gc.getDayName();
            
            switch(firstDate)
            {
                case "SUN":
                    startDateindex = 0;
                    break;
                case "MON":
                    startDateindex = 1;
                    break;
                case "TUE":
                    startDateindex = 2;
                    break;
                case "WED":
                    startDateindex = 3;
                    break;
                case "THU":
                    startDateindex = 4;
                    break;
                case "FRI":
                    startDateindex = 5;
                    break;
                case "SAT":
                    startDateindex = 6;
                    break;
            }
            int cntdays = 0;
            while(cntdays +1 <= GetCalender.month_day[month-1] && startDateindex + cntdays <35)
            {
                datelist[startDateindex + cntdays].Text = "" + (++cntdays);
            }
            
        }
        private void drawPlan()
        {
            Label[] planList = new Label[]
            {
                p00,p01,p02,p03,p04,p05,p06,
                p10,p11,p12,p13,p14,p15,p16,
                p20,p21,p22,p23,p24,p25,p26,
                p30,p31,p32,p33,p34,p35,p36,
                p40,p41,p42,p43,p44,p45,p46
            };
            //delete all
            foreach (Label d in planList)
            {
                d.Text = "";
            }

            DataTable dt = connection.SelectPlanByMonth(month);
            foreach (DataRow plan in dt.Rows)
            {
                string title = plan["title"].ToString();
                string contents = plan["contents"].ToString();
                DateTime startDate,endDate;
                DateTime.TryParse( plan["startDate"].ToString(),out startDate);
                DateTime.TryParse( plan["endDate"].ToString(),out endDate);
                for (int day = int.Parse(startDate.ToString("dd")) ;
                        day< int.Parse(endDate.ToString("dd"));
                        day++)
                {
                    if (planList[startDateindex + day - 1].Text.Length == 0)
                        planList[startDateindex + day - 1].Text = title;
                    else
                        planList[startDateindex + day - 1].Text += "\n" +  title;

                }
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void monthBeforeButton_Click(object sender, EventArgs e)
        {
            month--;
            if (month == 0) { year--; month = 12; }
            drawdate();
            drawPlan();
        }

        private void monthAfterButton_Click(object sender, EventArgs e)
        {
            month++;
            if (month == 13) { year++; month = 1; }
            drawdate();
            drawPlan();

        }

        private void addPlanButton_Click(object sender, EventArgs e)
        {
            PlanForm planform = new PlanForm(user);
            planform.Show();
        }
        private void plan_Click (object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString() ); 
        }
    }






    public class GetCalender
    {
        public string[] str_day = new string[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"};
        public static int[] month_day = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public int dayOne2000 = 6;          //2000년 1월 1일은 토요일
        public int year;
        public int month;
        public int day;
        // 윤년인지 여부 
        void IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                month_day[1] = 29;
        }

        // 날짜이름
        public string getDayName()
        {
            int total_day = 0;

            // 년
            IsLeapYear(year);

            // 달
            for (int i = 1; i < month; i++)
            {
                total_day += month_day[i - 1];
            }
            // 일
            total_day += day - 1;

            // 2016.1.1 = 금
            int answer_day = (3 + total_day) % 7;

            return str_day[answer_day];
        }
        public GetCalender(int year,int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
    }
}
