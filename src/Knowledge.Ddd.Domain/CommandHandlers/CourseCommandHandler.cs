using System.Threading;
using System.Threading.Tasks;
using Knowledge.Ddd.Domain.Commands;
using Knowledge.Ddd.Domain.Entities;
using Knowledge.Ddd.Domain.Interfaces;
using MediatR;

namespace Knowledge.Ddd.Domain.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository courseRepository;

        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course 
            { 
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };

            courseRepository.Add(course);

            return Task.FromResult(true);
        }
    }
}
