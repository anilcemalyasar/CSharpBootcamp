using Introduction.DataAccess.Abstracts;
using Introduction.DataAccess.Concretes;
using Introduction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Business
{
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;
        
        // Dependecy Injection Design Pattern
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }


        public List<Course> GetAll()
        {
            // business rules
            return _courseDal.GetAll();
        }

    }
}
