using System.Collections.Generic;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CarController: ControllerBase
    {
        [Route("makes")]
        public IActionResult Makes()
        {
            var makes = new List<Make> 
            {
                new Make { 
                          Id = 1,
                          Name ="Make1", 
                          Models = new List<Model> {
                          new Model {Id = 1, Name = "Model1"},
                          new Model {Id = 2, Name = "Model2"}
                         }
                }
            };
            return Ok(makes);
        }

        [Route("features")]
        public IActionResult Features()
        {
            var features = new List<Feature>{
                               new Feature {Id = 1,  Name = "Feature1"},
                               new Feature {Id = 2, Name = "Feature2"}
                            };
                return Ok(features);
        }
    }
}