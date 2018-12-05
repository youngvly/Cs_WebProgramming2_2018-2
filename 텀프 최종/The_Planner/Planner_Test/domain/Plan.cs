using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Planner.domain
{
    class Plan
    {
        public string title { get; set; }
        public string subject { get; set; }
        public string contents { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int userID { get; set; }
        public int isFixed { get; set; }
        public int planID{ get; set; }
}
}
