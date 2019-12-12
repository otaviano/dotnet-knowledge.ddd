using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knowledge.Ddd.Application.Interfaces;
using Knowledge.Ddd.Application.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Knowledge.Ddd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService courseService;

        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        // POST: api/Courses
        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel model)
        {
            courseService.Create(model);

            return Ok(model);
        }
    }
}
