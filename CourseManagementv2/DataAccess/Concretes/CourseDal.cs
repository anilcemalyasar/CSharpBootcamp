using CourseManagementv2.DataAccess.Abstracts;
using CourseManagementv2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementv2.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            Course course1 = new Course()
            {
                CourseId = 1,
                Name = "Senior Yazılım Geliştirici Yetiştirme Kampı",
                Description = ".Net dilinde ileri seviye konular işlenecek olan bu kurs Senior Yazılım Geliştiri yetiştirmeyi amaçlamaktadır!",
                UnitPrice = 0,
                CategoryId = 1,
                InstructorId = 1
            };

            Course course2 = new Course()
            {
                CourseId = 2,
                Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
                Description = ".Net Framework ile Back-End geliştirme alanında temelden ileri seviye konuların anlatılacağı bir kamp",
                UnitPrice = 0,
                CategoryId = 1,
                InstructorId = 1
            };

            Course course3 = new Course()
            {
                CourseId = 3,
                Name = "2023 Yazılım Geliştirici Yetiştirme Kampı (Python + Selenium)",
                Description = "Python temel ve ileri konseptleri, yazılım test frameworklerinden biri olan Selenium ile harmanlanarak verilecektir",
                UnitPrice = 0,
                CategoryId = 1,
                InstructorId = 2
            };

            courses = new List<Course> { course1, course2, course3 };
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course course)
        {
            courses.Remove(course);
            courses.Add(course);
        }
    }
}
