using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper autoMapper;

        public CourseService(IMapper autoMapper, ICourseRepository courseRepository, IMediatorHandler bus)
        {
            this.bus = bus;
            this.autoMapper = autoMapper;
            this.courseRepository = courseRepository;
        }

        public void Create(CourseViewModel model)
        {
            var command = autoMapper.Map<CreateCourseCommand>(model);

            bus.SendCommand(command);
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            var courses = courseRepository.GetAll();

            return courses.ProjectTo<CourseViewModel>(autoMapper.ConfigurationProvider) ;
        }
    }
}
