using Knowledge.Ddd.Domain.Entities;
using System.Collections.Generic;


namespace Knowledge.Ddd.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAll();
    }
}
