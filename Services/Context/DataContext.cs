using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAppBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogAppBackEnd.Services.Context
{
    public class DataContext : DbContext
    {
        public DbSet<ProjectModel> ProjectInfo {get; set;}
        public DbSet<TaskModel> TaskInfo  {get; set;}
        public DbSet<UserModel> UserInfo {get;set;}
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
