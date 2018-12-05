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
    class MakeConnection
    {
        public SqlConnection con;
        public Users user =new Users ();
        public MakeConnection(Users u)
        {
            string connetionString = "Data Source=Young;Initial Catalog=plan_db;Integrated Security=True";
            //string connetionString = plan_dbConnectionString;

            con = new SqlConnection(connetionString);
            user.Userid = u.Userid;
        }

        public PlanDBService makePlanDBModel()
        {
            return new PlanDBService(con, user);
        }
        public WeekPlanDBService makeWeekPlanDBModel()
        {
            return new WeekPlanDBService(con, user);
        }
    }

}
