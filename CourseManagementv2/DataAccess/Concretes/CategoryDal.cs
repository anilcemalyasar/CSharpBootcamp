using CourseManagementv2.DataAccess.Abstracts;
using CourseManagementv2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementv2.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;

        public CategoryDal()
        {
            Category category1 = new Category() { CategoryId = 1, Name = "Programlama" };
            Category category2 = new Category() { CategoryId = 2, Name = "Tümü" };
            categories = new List<Category> { category1, category2};
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category category)
        {
            categories.Remove(category);
            categories.Add(category);
        }
    }
}
