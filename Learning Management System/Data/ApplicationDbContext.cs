using System;
using System.Collections.Generic;
using System.Text;
using Learning_Management_System.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Learning_Management_System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Learning_Management_System.Models.Directions> Directions { get; set; }
        public DbSet<Learning_Management_System.Models.Course> Course { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Learning_Management_System.Models.MyCourses> MyCourses { get; set; }
        public DbSet<Learning_Management_System.Models.Comment> Comments { get; set; }
    }
}
