using Example1.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example1.Controller
{
    [Route("api/cities/")]
    public class PointOfInterestController : Microsoft.AspNetCore.Mvc.Controller       //기본컨트로러, 사실잘안씀 
    {
        [HttpGet("{id}/pointofinterest")]
        public IActionResult GetPointsOfInterest (int id)
        {
            var cities = CitiesStore.Instance.Cities;
            var city = cities.FirstOrDefault(c => c.Id == id);
            return Ok(city.PointsOfInterest);
        }
        [HttpGet("{cityid}/pointofinterest/{pointid}",Name = "GetPointOfInterestByPointId")]
        public IActionResult GetPointsOfInterest(int cityid, int pointid)
        {
            var cities = CitiesStore.Instance.Cities;
            var city = cities.FirstOrDefault(c => c.Id == cityid);

            var point = city.PointsOfInterest.FirstOrDefault(p => p.Id == pointid);
            return Ok(point);
        }

        [HttpDelete("{cityid}/pointofinterest/{pointid}")]
        public IActionResult DeletePointOfInterest(int cityid, int pointid)
        {
            //----->링큐사용
            CityDto city = CitiesStore.Instance.Cities.FirstOrDefault(c => c.Id == cityid);
            if (city == null) return NotFound();
            PointOfInterestDto point = city.PointsOfInterest.FirstOrDefault(p => p.Id == pointid);
            if (point == null) return NotFound();

            city.PointsOfInterest.Remove(point);            //list에서 지워주기만 하면됨.

            return NoContent();
        }

        [HttpPost ("{cityid}/pointofinterest")]
        public IActionResult CreatePointOfInterest(int cityid , 
            [FromBody]PointOfInterestForCreate pointOfInterestForCreate)
        {
            #region
            //string result = $@"[Name = {pointOfInterestForCreate.Name},Description = {pointOfInterestForCreate.Description}]";

            //오류처리
            if (pointOfInterestForCreate == null) return BadRequest("Data is Null");
            if (!ModelState.IsValid) return BadRequest();                  //Dto에 있는 required도 다 만족할때 true나옴.

            //city 검색
            //----->링큐사용
            CityDto city = CitiesStore.Instance.Cities.FirstOrDefault(c => c.Id == cityid);
            if (city == null) return NotFound();

            var points = city.PointsOfInterest;
            //---->링큐이용
            //int maxId = CitiesStore.Instance.Cities.SelectMany(c => c.PointsOfInterest).Max(p => p.Id);
            int maxId = city.PointsOfInterest.Max(p => p.Id);
            //insert points
            var createdPointOfInterest = new PointOfInterestDto()
            {
                Id = maxId + 1,
                Name = pointOfInterestForCreate.Name,
                Description = pointOfInterestForCreate.Description
            };

            points.Add(createdPointOfInterest);

            #endregion              //코드접기사용!
            return CreatedAtRoute("GetPointOfInterestByPointId",
                                    new { cityid = cityid , pointid = createdPointOfInterest.Id},
                                    createdPointOfInterest);
            //return Ok();
        }

        
    }
}
