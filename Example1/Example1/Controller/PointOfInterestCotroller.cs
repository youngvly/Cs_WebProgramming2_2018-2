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
        [HttpGet("{cityid}/pointofinterest/{pointid}")]
        public IActionResult GetPointsOfInterest(int cityid, int pointid)
        {
            var cities = CitiesStore.Instance.Cities;
            var city = cities.FirstOrDefault(c => c.Id == cityid);

            var point = city.PointsOfInterest.FirstOrDefault(p => p.Id == pointid);
            return Ok(point);
        }

        [HttpPost ("{cityid}/pointofinterest")]
        public IActionResult CreatePointOfInterest(int cityid , 
            [FromBody]PointOfInterestForCreate pointOfInterestForCreate)
        {
            string result = $@"[Name = {pointOfInterestForCreate.Name},
                    Description = {pointOfInterestForCreate.Description}]";
            if (pointOfInterestForCreate == null) return BadRequest();

            //city 검색
            List<CityDto> cities  = CitiesStore.Instance.Cities;

            CityDto city = null;
            foreach(var c in cities)
            {
                if (c.Id== cityid)
                {
                    city = c;
                }
            }
            if (city == null) return NotFound();

            //
            var points = city.PointsOfInterest;
            //find id
            int maxId = 0;
            foreach (var p in points)
            {
                if (p.Id > maxId) maxId = p.Id; 
            }
            //insert points
            var createdPointOfInterest = new PointOfInterestDto()
            {
                Id = maxId + 1,
                Name = pointOfInterestForCreate.Name,
                Description = pointOfInterestForCreate.Description
            };

            points.Add(createdPointOfInterest);


            return Ok(result);
        } 

    }
}
