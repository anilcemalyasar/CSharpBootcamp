using CourseManagementv2.DataAccess.Abstracts;
using CourseManagementv2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementv2.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;

        public InstructorDal()
        {
            Instructor instructor1 = new Instructor() { InstructorId = 1, FirstName = "Engin", LastName = "Demirog" };
            Instructor instructor2 = new Instructor() { InstructorId = 2, FirstName = "Halit Enes", LastName = "Kalaycı" };
            instructors = new List<Instructor> { instructor1, instructor2};
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor instructor)
        {
            instructors.Remove(instructor);
            instructors.Add(instructor);
        }
    }
}
