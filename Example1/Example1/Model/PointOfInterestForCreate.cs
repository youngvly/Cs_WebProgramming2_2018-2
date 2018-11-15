using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Example1.Model
{
    public class PointOfInterestForCreate
    {
        [Required]                          //Name은 반드시 필요하다. Name이 Post로 안들어가면 오류뜨게.
        [MaxLength(10)]                     //Name의 최대길이는 10             
                                            //---->Controller에서 ModelState.IsValid로 오류처리 해야함
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
