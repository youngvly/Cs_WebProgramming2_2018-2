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

        public PlanDBModel makePlanDBModel()
        {
            return new PlanDBModel(con, user);
        }

    }

}
