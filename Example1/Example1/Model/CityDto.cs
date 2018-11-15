using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example1.Model
{
    public class CityDto            //Data Type Object
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Count
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }
        public List<PointOfInterestDto> PointsOfInterest { get; set; }
       
    }
}
