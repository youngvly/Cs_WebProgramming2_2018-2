using The_Planner.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Planner.DBControl
{
    class PlanDBService
    {
        public SqlConnection con;
        public Users user = new Users();
        public PlanDBService(SqlConnection con, Users user)
        {
            this.user = user;
            this.con = con;
        }
        public DataTable SelectPlanByMonth(int month)
        {
            string commands = "SELECT * FROM plans WHERE  userid = '" + user.Userid + "' AND Month(startDate) ='" + month + "' AND Fixed = 0";

            SqlDataAdapter dap = new SqlDataAdapter(commands, con);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            return dt;
        }

        public DataTable SelectPlanByDateTime(DateTime dateTime)
        {
            int year = dateTime.Year;
            int month = dateTime.Month;
            int day = dateTime.Day;
            string commands = "SELECT * FROM plans WHERE  userid = '" + user.Userid + "' AND Day(startDate) ='" + day+ 
                                "                       ' AND Month(startDate) = '" + month + "' AND Year(startDate) = '" + year + "'";

            SqlDataAdapter dap = new SqlDataAdapter(commands, con);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            return dt;
        }

        public Plan SelectPlanByPlanid(int planid)
        {
            Plan plan = new Plan();
            string commands = $@"SELECT * FROM plans WHERE planid = {planid}";

            SqlDataAdapter dap = new SqlDataAdapter(commands, con);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            foreach (DataRow d in dt.Rows)
            {
                plan.title = d["title"].ToString();
                plan.contents = d["contents"].ToString();
                plan.subject = d["subject"].ToString();
                DateTime startDate, endDate;
                DateTime.TryParse(d["startDate"].ToString(), out startDate);
                DateTime.TryParse(d["endDate"].ToString(), out endDate);
                plan.startDate = startDate;
                plan.endDate = endDate;
                plan.planID = int.Parse(d["planid"].ToString());
            }
            return plan;
        }

        public void AddPlan(Plan plan)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = con;            // <== lacking
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO plans (title,subject,contents,startDate,endDate,userid,fixed) " +
                                        "VALUES (@title, @subject, @contents, @startDate, @endDate,@userId,@fixed)";
                command.Parameters.AddWithValue("@title", plan.title);
                command.Parameters.AddWithValue("@subject", plan.subject);
                command.Parameters.AddWithValue("@contents", plan.contents);
                //Console.WriteLine(plan.startDate);
                command.Parameters.AddWithValue("@startDate", plan.startDate.ToString("yyyy-MM-dd HH:mm:ss"));
                command.Parameters.AddWithValue("@endDate", plan.endDate.ToString("yyyy-MM-dd HH:mm:ss"));
                command.Parameters.AddWithValue("@userId", user.Userid);
                command.Parameters.AddWithValue("@fixed", plan.isFixed);

                try
                {
                    con.Open();
                    int recordsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public void dropPlan(Plan plan)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = con;            // <== lacking
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM plans WHERE planid = @planid";
                command.Parameters.AddWithValue("@planid", plan.planID);

                try
                {
                    con.Open();
                    int recordsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public void editPlan(Plan plan)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = con;            // <== lacking
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE plans SET title = @title , subject = @subject , contents = @contents, startDate = @startDate , endDate = @endDate " +
                                    "WHERE planid = @planid";
                command.Parameters.AddWithValue("@title",plan.title );
                command.Parameters.AddWithValue("@subject", plan.subject);
                command.Parameters.AddWithValue("@contents", plan.contents);
                command.Parameters.AddWithValue("@startDate", plan.startDate.ToString("yyyy-MM-dd HH:mm:ss"));
                command.Parameters.AddWithValue("@endDate", plan.endDate.ToString("yyyy-MM-dd HH:mm:ss"));
                command.Parameters.AddWithValue("@planid", plan.planID);
                try
                {
                    con.Open();
                    int recordsAffected = command.ExecuteNonQuery();
                    Console.WriteLine(recordsAffected);
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    Console.WriteLine(command.CommandText);
                }
                finally
                {
                    con.Close();
                }
            }
        }

    }
}
