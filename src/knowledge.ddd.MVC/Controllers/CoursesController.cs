using Knowledge.Ddd.Application.Interfaces;
using Knowledge.Ddd.Application.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Knowledge.Ddd.Mvc.Controllers
{
    [Authorize]
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;

        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        // GET: Course
        public ActionResult Index()
        {
            var courses = courseService.GetCourses();

            return View(courses);
        }
    }
}