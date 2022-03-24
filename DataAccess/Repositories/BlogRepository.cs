using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repositories
{
    public class BlogRepository : IBlogDal
    {
        
        public void AddBlog(Blog blog)
        {
            using var c = new Context();
            c.Add(blog); ;
            c.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var c = new Context();
            c.Remove(blog); ;
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllCategory()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            using var c = new Context();
            c.Update(blog); ;
            c.SaveChanges();
        }
    }
}
