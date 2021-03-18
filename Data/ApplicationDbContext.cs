using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace INStudio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Partnior> Partniors { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }

        public DbSet<Page> Pages { get; set; }

        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryProject> CategoryProjects { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<GalleryImage>().HasKey(gi => new { gi.GalleryId, gi.ImageId });
            builder.Entity<CategoryProject>().HasKey(cp => new { cp.CategoryId, cp.ProjectId });


            //builder.Entity<GalleryImage>().HasOne(gi => gi.Gallery).WithMany(g => g.GalleryImages).HasForeignKey(gi => gi.GalleryId);
            //builder.Entity<GalleryImage>().HasOne(gi => gi.Image).WithMany(i => i.GalleryImages).HasForeignKey(gi => gi.ImageId);
        }
    }
}
