﻿using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public  class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-7IA3EPO;database=CoreBlogDb;integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
