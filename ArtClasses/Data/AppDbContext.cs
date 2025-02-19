using ArtClasses.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace ArtClasses.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseReview> CourseReviews { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User -> Teacher (1:1)
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.User)
                .WithOne()
                .HasForeignKey<Teacher>(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User -> CourseReview ( 1 : N )
            modelBuilder.Entity<CourseReview>()
                .HasOne(cr => cr.User)
                .WithOne()
                .HasForeignKey<CourseReview>(cr => cr.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Course -> CourseReview (1 : N)
            modelBuilder.Entity<CourseReview>()
                .HasOne(cr => cr.Course)
                .WithOne()
                .HasForeignKey<CourseReview>(cr => cr.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            // Course -> Lesson (1: N)
            modelBuilder.Entity<Lesson>()
                .HasOne(l => l.Course)
                .WithMany()
                .HasForeignKey(l => l.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
                
        }

    }
}
