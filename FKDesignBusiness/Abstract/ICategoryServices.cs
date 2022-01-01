using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Abstract
{
    public interface ICategoryServices
    {
        Task<IEnumerable<Category>> GetAllCategories(); //tüm kategorileri getir
        Task<Category> GetCategoryById(int id); //idsi ? olan kategoriyi getir
        Task<Category> CreateCategory(Category category); //entity
        Task UpdateCategory(Category categoryToBeUpdate, Category category);
        Task DeleteCategory(Category category);
    }
}
