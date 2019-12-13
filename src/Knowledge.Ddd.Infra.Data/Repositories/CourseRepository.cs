using Knowledge.Ddd.Domain.Entities;
using Knowledge.Ddd.Domain.Interfaces;
using Knowledge.Ddd.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Knowledge.Ddd.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext dbContext;

        public CourseRepository(UniversityDBContext dbContext) => 
            this.dbContext = dbContext;

        public IQueryable<Course> GetAll() => 
            dbContext.Courses;

        public void Add(Course course)
        {
            dbContext.Courses.Add(course);
            dbContext.SaveChanges();
        }
    }
}
