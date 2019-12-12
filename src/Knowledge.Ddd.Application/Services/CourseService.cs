using System.Collections.Generic;
using Knowledge.Ddd.Application.Interfaces;
using Knowledge.Ddd.Application.ViewModel;
using Knowledge.Ddd.Domain.Commands;
using Knowledge.Ddd.Domain.Core.Bus;
using Knowledge.Ddd.Domain.Interfaces;

namespace Knowledge.Ddd.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;
        private readonly IMediatorHandler bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            this.bus = bus;
            this.courseRepository = courseRepository;
        }

        public void Create(CourseViewModel model)
        {
            var command = new CreateCourseCommand(model.Name, model.Description, model.ImageUrl);

            bus.SendCommand(command);
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
