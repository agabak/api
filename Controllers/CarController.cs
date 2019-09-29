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
            var cars = new List<Car> 
            {
                new Car { Make ="BMW", Model ="X5", 
                          Features = new List<Feature> {
                          new Feature { Name = "Lethear seat"},
                          new Feature { Name = "Automatic transimision"}
                         }
                },
                new Car { Make ="BMW", Model ="X-model- news", 
                          Features = new List<Feature> {
                          new Feature { Name = "Lethear seat"},
                          new Feature { Name = "Automatic transimision"}
                         }
                }
            };
            return Ok(cars);
        }

        [Route("features")]
        public IActionResult Features()
        {
            var features = new List<Feature>{
                               new Feature { Name = "Lethear seat"},
                               new Feature { Name = "Automatic transimision"}
                            };
                return Ok(features);
        }
    }
}