using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example1.Model
{
    public class CitiesStore
    {
        //priave 생성자 +static 인스턴스 = 싱글톤 
        //팩토리패턴 만들때 사용하는 방법.
        public static CitiesStore Instance { get;} = new CitiesStore();
        public List<CityDto> Cities { get; set; }

        private CitiesStore()
        {
            Cities = new List<CityDto>()
            {
               new CityDto()
               {
                   Id = 1,
                   Name = "천안",
                   Description = "천안삼거리",
                   PointsOfInterest = new List<PointOfInterestDto>()
                   {
                       new PointOfInterestDto()
                       {
                           Id = 1,
                           Name = "천안삼거리",
                           Description = "흥타령 축제"
                       },
                       new PointOfInterestDto()
                       {
                           Id = 2,
                           Name = "한국기술교육대학교",
                           Description = "아우내"
                       },
                       new PointOfInterestDto()
                       {
                           Id = 3,
                           Name = "야우리",
                           Description = "터미널쇼핑"
                       }
                   }
               },
               new CityDto ()
               {
                   Id = 2,
                   Name = "서울",
                   Description = "가산디지털단지",
                   PointsOfInterest = new List<PointOfInterestDto>()
                   {
                       new PointOfInterestDto()
                       {
                           Id = 1,
                           Name = "가산",
                           Description = "흥타령 축제"
                       }
                   }
               },
               new CityDto ()
               {
                   Id = 3,
                   Name = "부산",
                   Description = "해운대",
                   PointsOfInterest = new List<PointOfInterestDto>()
                   {
                       new PointOfInterestDto()
                       {
                           Id = 1,
                           Name = "해운대",
                           Description = "바닷가"
                       }
                   }
               }
            };

            //CityDto city = new CityDto();
            //city.Id = 1;
            //city.Name = "천안";
            //city.Description = "천안삼거리";

            //CityDto city2 = new CityDto()
            //{
            //    Id = 1,
            //    Name = "천안",
            //    Description = "천안삼거리"
            //};

            //Cities.Add(city);

        }

    }
}
