using Knowledge.Ddd.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Knowledge.Ddd.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetAll();

        void Add(Course course);
    }
}
