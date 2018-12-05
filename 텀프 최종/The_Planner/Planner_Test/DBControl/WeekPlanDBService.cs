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
    class WeekPlanDBService
    {
        public SqlConnection con;
        public Users user = new Users();
        public WeekPlanDBService(SqlConnection con, Users user)
        {
            this.con = con;
            this.user = user;
        }

        public DataTable SelectPlanByWeekDay(string weekday)
        {
            string commands = "SELECT * FROM weekPlan WHERE  userid = '" + user.Userid + "' AND dayOfWeek ='" + weekday + "'";

            SqlDataAdapter dap = new SqlDataAdapter(commands, con);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            return dt;
        }

        public void AddWeekPlan(WeekPlan weekplan)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = con;            // <== lacking
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO weekPlan (title , contents,startTime,endTime,userid,dayOfWeek) " +
                                        "VALUES (@title,@contents, @startTime, @endTime,@userId,@dayOfWeek)";
                command.Parameters.AddWithValue("@title", weekplan.title);
                command.Parameters.AddWithValue("@contents", weekplan.contents);
                command.Parameters.AddWithValue("@userId", weekplan.userId);
                command.Parameters.AddWithValue("@startTime", weekplan.startTime);
                command.Parameters.AddWithValue("@endTime", weekplan.endTime);
                command.Parameters.AddWithValue("@dayOfWeek", weekplan.dayOfWeek);

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
