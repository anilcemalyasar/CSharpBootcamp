using CourseManagementv2.Business.Abstracts;
using CourseManagementv2.Business.Concretes;
using CourseManagementv2.DataAccess.Concretes;
using CourseManagementv2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICourseManager courseManager = new CourseManager(new CourseDal());
            List<Course> courses = courseManager.GetAll();
            foreach (Course course in courses)
            {
                Console.WriteLine($"Course Id: {course.CourseId}\nCourse Name: {course.Name}\nCourse Description: {course.Description}");
                Console.WriteLine("*************");
            }

            Course newCourse = new Course()
            {
                CourseId = 4,
                Name = "Programlamaya giriş için temel kurs",
                Description = "Programlama temellerinin öğretileceği bir kurstur!",
                UnitPrice = 0,
                InstructorId = 1,
                CategoryId = 2
            };

            courseManager.Add(newCourse);

            courses = courseManager.GetAll();
            foreach (Course course in courses)
            {
                Console.WriteLine($"Course Id: {course.CourseId}\nCourse Name: {course.Name}\nCourse Description: {course.Description}");
                Console.WriteLine("*************");
            }

            Console.ReadLine();
        }
    }
}
