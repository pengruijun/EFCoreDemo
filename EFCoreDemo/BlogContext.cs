using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }  = null!;
        public DbSet<Post> Posts { get; set; }= null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().ToTable("Blog");
            modelBuilder.Entity<Post>().ToTable("Post");

            modelBuilder.Entity<Blog>().HasData(new Blog
            { ID = 1, Name = "blog1" });

            modelBuilder.Entity<Post>().HasData(
                new Post{ ID = 1, Title = "post1.1", BlogId = 1 },
                new Post { ID = 2, Title="post1.2", BlogId = 1}
            ); 
        }
    }
}
