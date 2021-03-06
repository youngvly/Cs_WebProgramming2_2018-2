﻿using Planner_Test.DBControl;
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
    public partial class PlanShow : Form
    {
        private int[] planid;
        private List<Plan> planlist = new List<Plan>();
        private PlanDBModel pdm;
        private int pageIndex = 0;
        public PlanShow(Users user,int[] planid)
        {
            InitializeComponent();
            pdm = new MakeConnection(user).makePlanDBModel();
            this.planid = planid;
            comboBox1.Items.Add("예약");
            comboBox1.Items.Add("과제");
            comboBox1.Items.Add("여행");
            comboBox1.Items.Add("모임");
            comboBox1.Items.Add("기타");

            foreach (var pid in planid)
            {
                planlist.Add(pdm.SelectPlanByPlanid(pid));
            }
            planshow_action(pageIndex);
        }

        public void planshow_action(int pageIndex)
        {
            Plan plan = planlist.ElementAt(pageIndex);
            if (plan.title == null)
            {
                MessageBox.Show("일정이 없습니다.");
            }
            else
            {
                title.Text = plan.title;
                contents.Text = plan.contents;
                comboBox1.Text = plan.subject;
                startDate.Value = plan.startDate;
                endDate.Value = plan.endDate;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Plan editplan = new Plan();
            editplan.title = title.Text;
            editplan.contents = contents.Text;
            editplan.subject = comboBox1.Text;
            editplan.startDate = startDate.Value;
            editplan.endDate = endDate.Value;
            editplan.planID = planid[pageIndex];

            pdm.editPlan(editplan);
            this.Close();
        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            pdm.dropPlan(planlist.ElementAt(pageIndex));
            this.Close();
        }

        private void BeforeButton_Click(object sender, EventArgs e)
        {
            if (pageIndex > 0) planshow_action(--pageIndex);
            else
            {
                MessageBox.Show("첫페이지입니다.");
            }
        }

        private void AfterButton_Click(object sender, EventArgs e)
        {
            if (pageIndex <  planlist.Count) planshow_action(++pageIndex);
            else
            {
                MessageBox.Show("마지막페이지입니다.");
            }
        }
    }
}
