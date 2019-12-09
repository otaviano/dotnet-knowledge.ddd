using Knowledge.Ddd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Knowledge.Ddd.Application.ViewModel
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
