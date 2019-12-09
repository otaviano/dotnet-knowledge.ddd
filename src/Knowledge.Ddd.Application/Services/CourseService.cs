using System.Collections.Generic;
using Knowledge.Ddd.Application.Interfaces;
using Knowledge.Ddd.Application.ViewModel;
using Knowledge.Ddd.Domain.Interfaces;

namespace Knowledge.Ddd.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = courseRepository.GetAll()
            };
        }
    }
}
