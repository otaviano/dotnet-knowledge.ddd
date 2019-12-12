using Knowledge.Ddd.Application.ViewModel;
using System.Collections.Generic;

namespace Knowledge.Ddd.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
        void Create(CourseViewModel model);
    }
}
