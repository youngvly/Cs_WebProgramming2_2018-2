using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Planner.domain
{
    public class Users
    {
        private int userid;

        public int Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
