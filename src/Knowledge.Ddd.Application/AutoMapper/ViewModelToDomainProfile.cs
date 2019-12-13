using AutoMapper;
using Knowledge.Ddd.Application.ViewModel;
using Knowledge.Ddd.Domain.Commands;

namespace Knowledge.Ddd.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(p => new CreateCourseCommand(p.Name, p.Description, p.ImageUrl));
        }

    }
}
