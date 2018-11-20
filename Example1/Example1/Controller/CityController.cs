using Example1.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example1.Controller
{
    public class CityController : Microsoft.AspNetCore.Mvc.Controller       //기본컨트로러, 사실잘안씀 
    {
        [HttpGet("api/cities")]
        //public JsonResult GetCities()   //jsonResult 는 404Notfound를 뱉어내지못함!
        //{
        //    //List<Object> list = new List<object>();
        //    //list.Add(new { Id = 1, Name = "천안" });
        //    //list.Add(new { Id = 2, Name = "서울" });
        //    //list.Add(new { Id = 3, Name = "부산" });

        //    return new JsonResult(CitiesStore.Instance.Cities);
        //}
        public IActionResult GetCities()   //jsonResult 는 404Notfound를 뱉어내지못함!
        {
           
            return Ok(CitiesStore.Instance.Cities);
        }
        [HttpGet("api/cities/{id}")]
        public IActionResult GetCity (int id)
        {
            //List<CityDto> list = CitiesStore.Instance.Cities;
            CityDto findResult = CitiesStore.Instance.Cities
                .FirstOrDefault(CityController => CityController.Id == id);
            //CityDto findResult = null;
            //foreach (var city in list)
            //{
            //    if (city.Id == id)
            //    {
            //        findResult = city;
            //    }
            //}
            if (findResult == null)
                return NotFound();
            else
                return Ok(findResult);
        }
    }
}
