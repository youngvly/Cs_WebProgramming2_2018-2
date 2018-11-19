using Planner_Test.DBControl;
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
    public partial class PlanForm : Form
    {
        private Plan plan = new Plan();
        private PlanDBModel pdm;
        public PlanForm(Users user)
        {
            pdm = new MakeConnection(user).makePlanDBModel();
            InitializeComponent();

            comboBox1.Items.Add("예약");
            comboBox1.Items.Add("과제");
            comboBox1.Items.Add("여행");
            comboBox1.Items.Add("모임");
            comboBox1.Items.Add("기타");
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
                plan.startDate = dateTimePicker1.Value;
                plan.endDate = dateTimePicker2.Value;

                pdm.AddPlan(plan);
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
