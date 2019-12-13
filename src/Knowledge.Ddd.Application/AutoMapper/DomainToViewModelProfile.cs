using AutoMapper;
using Knowledge.Ddd.Application.ViewModel;
using Knowledge.Ddd.Domain.Commands;
using Knowledge.Ddd.Domain.Entities;

namespace Knowledge.Ddd.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}
