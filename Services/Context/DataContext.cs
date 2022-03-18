using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using get_shit_done_webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace get_shit_done_webapi.Services.Context
{
    public class DataContext : DbContext
    {
        public DbSet<ProjectModel> ProjectInfo { get; set; }
        public DbSet<TaskModel> TaskInfo { get; set; }
        public DbSet<UserModel> UserInfo { get; set; }
        public DbSet<SpecialistProjectModel> SpecialistProjectInfo { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            var defaultData = new List<UserModel>()
            {
                new UserModel(){
                    Id= 1,
                    Username = "JT",
                    Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                    Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                    Role = "Owner",
                    isAdmin = true,
                    isOwner = true,
                    isRevoked = false,
                    isDeleted = false
                },
                new UserModel(){
                    Id= 2,
                    Username = "Angel",
                    Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                    Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                    Role = "Admin",
                    isAdmin = true,
                    isOwner = false,
                    isRevoked = false,
                    isDeleted = false
                },
                new UserModel(){
                    Id= 3,
                    Username = "Walaa",
                    Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                    Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                    Role = "Admin",
                    isAdmin = true,
                    isOwner = false,
                    isRevoked = false,
                    isDeleted = false
                },
                new UserModel(){
                    Id= 4,
                    Username = "Henry",
                    Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                    Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                    Role = "Specialist",
                    isAdmin = false,
                    isOwner = false,
                    isRevoked = false,
                    isDeleted = false
                },
                new UserModel(){
                    Id= 5,
                    Username = "Bob",
                    Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                    Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                    Role = "Specialist",
                    isAdmin = false,
                    isOwner = false,
                    isRevoked = true,
                    isDeleted = false
                },
                new UserModel(){
                    Id= 6,
                    Username = "Frank",
                    Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                    Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                    Role = "Specialist",
                    isAdmin = false,
                    isOwner = false,
                    isRevoked = false,
                    isDeleted = false
                },
                new UserModel(){
                    Id= 7,
                    Username = "Jacob",
                    Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                    Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                    Role = "Specialist",
                    isAdmin = false,
                    isOwner = false,
                    isRevoked = true,
                    isDeleted = false
                },
                new UserModel(){
                    Id= 8,
                    Username = "Jamie",
                    Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                    Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                    Role = "Specialist",
                    isAdmin = false,
                    isOwner = false,
                    isRevoked = true,
                    isDeleted = false
                },
                new UserModel(){
                    Id= 9,
                    Username = "John",
                    Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                    Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                    Role = "Specialist",
                    isAdmin = false,
                    isOwner = false,
                    isRevoked = false,
                    isDeleted = false
                },
                new UserModel(){
                    Id= 10,
                    Username = "Spleeter",
                    Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                    Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                    Role = "Specialist",
                    isAdmin = false,
                    isOwner = false,
                    isRevoked = false,
                    isDeleted = false
                },
                new UserModel(){
                    Id= 11,
                    Username = "Jessie",
                    Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                    Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                    Role = "Specialist",
                    isAdmin = false,
                    isOwner = false,
                    isRevoked = false,
                    isDeleted = false
                },
                new UserModel(){
                    Id= 12,
                    Username = "Hector",
                    Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                    Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                    Role = "Specialist",
                    isAdmin = false,
                    isOwner = false,
                    isRevoked = true,
                    isDeleted = false
                },
                new UserModel(){
                    Id= 13,
                    Username = "Bobby",
                    Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                    Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                    Role = "Specialist",
                    isAdmin = false,
                    isOwner = false,
                    isRevoked = false,
                    isDeleted = true
                },
            };
            builder.Entity<UserModel>().HasData(defaultData);

            var defaultProjectData = new List<ProjectModel>()
            {
                new ProjectModel(){
                     Id =1,
                     UserId = 1,
                     ProjectName ="Expired?",
                     ProjectDescription="Check if food is expired",
                     DateCreate ="3/18/22",
                     DueDate ="3/30/22",
                     StatusOfProject = "InProgress",
                     PriorityOfProject = "Low",
                     isDeleted = false,
                     isArchived = false
                },
                new ProjectModel(){
                     Id =2,
                     UserId = 2,
                     ProjectName ="Expired?",
                     ProjectDescription="Check if food is expired",
                     DateCreate ="6/12/22",
                     DueDate ="7/30/22",
                     StatusOfProject = "InProgress",
                     PriorityOfProject = "Medium",
                     isDeleted = true,
                     isArchived = false
                },
                new ProjectModel(){
                     Id = 3,
                     UserId = 3,
                     ProjectName ="ChickFlicks",
                     ProjectDescription="Pick a Movie with your Friends",
                     DateCreate ="3/15/22",
                     DueDate ="4/01/22",
                     StatusOfProject = "Completed",
                     PriorityOfProject = "High",
                     isDeleted = false,
                     isArchived = false
                },
                new ProjectModel(){
                     Id = 4,
                     UserId = 4,
                     ProjectName ="BurgerShot",
                     ProjectDescription="Sell Burger",
                     DateCreate ="8/2/22",
                     DueDate ="4/01/23",
                     StatusOfProject = "Completed",
                     PriorityOfProject = "High",
                     isDeleted = true,
                     isArchived = false
                },
                
            };
            builder.Entity<ProjectModel>().HasData(defaultProjectData);

            var defaultSpecialistData = new List<SpecialistProjectModel>()
            {
                new SpecialistProjectModel(){
                    
                    Id = 1,
                    UserId = 1,
                    ProjectId = 1
                },
                new SpecialistProjectModel(){
                    
                    Id = 2,
                    UserId = 2,
                    ProjectId = 2
                },
                new SpecialistProjectModel(){
                    
                    Id = 3,
                    UserId = 3,
                    ProjectId = 3
                },
                new SpecialistProjectModel(){
                    Id = 4,
                    UserId = 1,
                    ProjectId =  2
                },
                new SpecialistProjectModel(){
                    Id = 5,
                    UserId = 1,
                    ProjectId =  3
                },
                new SpecialistProjectModel(){
                    Id = 6,
                    UserId = 2,
                    ProjectId =  4
                }
                 new SpecialistProjectModel(){
                    Id = 7,
                    UserId = 3,
                    ProjectId =  4
                }
                
                
            };
            builder.Entity<SpecialistProjectModel>().HasData(defaultSpecialistData);

            var defaultTaskData = new List<TaskModel>()
            {
                new TaskModel(){
                    Id = 1,
                    specialistId = 2,
                    ProjectId = 3,
                    TaskName ="ChickFlicksFrontEnd",
                    TaskDateCreate="Build Front End for ChicksFlicks",
                    TaskDescription = "Create the front end for app",
                    PriorityOfTask ="High",
                    StatusOfTask ="InProgress",
                    TaskDueDate = "05/01/2022",
                    TaskIsDeleted = false,
                    TaskisArchived = false,
                    specialistName = "An"
                },
                new TaskModel(){
                    Id = 2,
                    specialistId = 6,
                    ProjectId = 3,
                    TaskName ="ChickFlicksBackEnd",
                    TaskDateCreate="Build Back End for ChicksFlicks",
                    TaskDescription = "Create the back end for app",
                    PriorityOfTask ="High",
                    StatusOfTask ="Completed",
                    TaskDueDate = "05/01/2022",
                    TaskIsDeleted = false,
                    TaskisArchived = false,
                    specialistName = "Hector"
                },
                new TaskModel(){
                    Id = 3,
                    specialistId = 3,
                    ProjectId = 1,
                    TaskName ="ChickFlicksFrontEnd",
                    TaskDateCreate="Build Front End for ChicksFlicks",
                    TaskDescription = "Create the front end for app",
                    PriorityOfTask ="Low",
                    StatusOfTask ="InProgress",
                    TaskDueDate = "05/01/2022",
                    TaskIsDeleted = false,
                    TaskisArchived = false,
                    specialistName = "Jessie"
                },
                new TaskModel(){
                    Id = 4,
                    specialistId = 2,
                    ProjectId = 4,
                    TaskName ="BurgerShot BackEnd",
                    TaskDateCreate="Build Back End for BurgerShot",
                    TaskDescription = "Create the back end for BurgerShot",
                    PriorityOfTask ="Low",
                    StatusOfTask ="InProgress",
                    TaskDueDate = "03/18/2022",
                    TaskIsDeleted = false,
                    TaskisArchived = false,
                    specialistName = "Bob"
                }
            };
            builder.Entity<TaskModel>().HasData(defaultTaskData);
            
            
        }
    }
}
    
        
    

