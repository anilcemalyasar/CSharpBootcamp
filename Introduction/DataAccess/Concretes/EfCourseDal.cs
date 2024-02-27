using Introduction.DataAccess.Abstracts;
using Introduction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.DataAccess.Concretes
{
    public class EfCourseDal : ICourseDal
    {
        List<Course> courses;

        public EfCourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "Javascript";
            course1.Description = "JS 11.1";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "React";
            course2.Description = "JS 10.9";
            course2.Price = 10;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "Python";
            course3.Description = "Python 3.12";
            course3.Price = 20;

            courses = new List<Course> { course1, course2, course3 };
        }
        public void Add(Course course)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            return courses;
        }
    }
}
