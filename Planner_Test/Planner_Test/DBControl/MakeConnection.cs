using Planner_Test.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner_Test.DBControl
{
    class MakeConnection
    {
        public SqlConnection con;
        public Users user =new Users ();
        public MakeConnection(Users u)
        {
            string connetionString = "Data Source=Young;Initial Catalog=plan_db;Integrated Security=True";

            con = new SqlConnection(connetionString);
            user.Userid = u.Userid;
        }

        public DataTable SelectPlanByMonth(int month)
        {
            string commands = "SELECT * FROM plans WHERE  userid = '" + user.Userid + "' AND Month(startDate) ='" + month + "'";

            SqlDataAdapter dap = new SqlDataAdapter(commands, con);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            return dt;
        }
        public void AddPlan(Plan plan)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = con;            // <== lacking
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO plans (title,subject,contents,startDate,endDate,userid,fixed) " +
                                        "VALUES (@title, @subject, @contents, @startDate, @endDate,@userId,@fixed)";
                command.Parameters.AddWithValue("@title",plan.title);
                command.Parameters.AddWithValue("@subject", plan.subject);
                command.Parameters.AddWithValue("@contents", plan.contents);
                Console.WriteLine(plan.startDate);
                command.Parameters.AddWithValue("@startDate", plan.startDate.ToString("yyyy-MM-dd hh:mm:ss"));
                command.Parameters.AddWithValue("@endDate", plan.endDate.ToString("yyyy-MM-dd hh:mm:ss"));
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
            /*string commands = "INSERT INTO plans ('title','subject','contents','startDate','endDate')"
                + "('" + plan.title + "','" + plan.subject + "','" + plan.contents + "','" + plan.startDate.ToString("yyyy-MM-dd hh:mm:ss") + "','" + plan.endDate.ToString("yyyy-MM-dd hh:mm:ss") + "')";
                */

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
        
    }

}
