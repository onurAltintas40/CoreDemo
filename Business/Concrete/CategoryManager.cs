﻿using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepository.GetListAll();
        }
    }
}
