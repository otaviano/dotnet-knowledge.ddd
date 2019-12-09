using Knowledge.Ddd.Domain.Entities;
using Knowledge.Ddd.Domain.Interfaces;
using Knowledge.Ddd.Infra.Data.Context;
using System.Collections.Generic;

namespace Knowledge.Ddd.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext dbContext;

        public CourseRepository(UniversityDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Course> GetAll()
        {
            return dbContext.Courses;
        }
    }
}
