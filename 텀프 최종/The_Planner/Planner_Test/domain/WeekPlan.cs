using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Planner.domain
{
    class WeekPlan
    {
        public string dayOfWeek { get; set; }
        public string title { get; set; }
        public string contents { get; set; }
        public int weekPlanId { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public int userId { get; set; }

    }
}
