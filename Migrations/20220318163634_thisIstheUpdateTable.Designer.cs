﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using get_shit_done_webapi.Services.Context;

#nullable disable

namespace get_shit_done_webapi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220318163634_thisIstheUpdateTable")]
    partial class thisIstheUpdateTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("get_shit_done_webapi.Models.ProjectModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DateCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DueDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PriorityOfProject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusOfProject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isArchived")
                        .HasColumnType("bit");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ProjectInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreate = "3/18/22",
                            DueDate = "3/30/22",
                            PriorityOfProject = "Low",
                            ProjectDescription = "Check if food is expired",
                            ProjectName = "Expired?",
                            StatusOfProject = "InProgress",
                            UserId = 1,
                            isArchived = false,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            DateCreate = "6/12/22",
                            DueDate = "7/30/22",
                            PriorityOfProject = "Medium",
                            ProjectDescription = "Check if food is expired",
                            ProjectName = "Expired?",
                            StatusOfProject = "InProgress",
                            UserId = 2,
                            isArchived = false,
                            isDeleted = true
                        },
                        new
                        {
                            Id = 3,
                            DateCreate = "3/15/22",
                            DueDate = "4/01/22",
                            PriorityOfProject = "High",
                            ProjectDescription = "Pick a Movie with your Friends",
                            ProjectName = "ChickFlicks",
                            StatusOfProject = "Completed",
                            UserId = 3,
                            isArchived = false,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            DateCreate = "8/2/22",
                            DueDate = "4/01/23",
                            PriorityOfProject = "High",
                            ProjectDescription = "Sell Burger",
                            ProjectName = "BurgerShot",
                            StatusOfProject = "Completed",
                            UserId = 4,
                            isArchived = false,
                            isDeleted = true
                        });
                });

            modelBuilder.Entity("get_shit_done_webapi.Models.SpecialistProjectModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SpecialistProjectInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProjectId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ProjectId = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            ProjectId = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            ProjectId = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            ProjectId = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            ProjectId = 4,
                            UserId = 2
                        },
                        new
                        {
                            Id = 7,
                            ProjectId = 4,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("get_shit_done_webapi.Models.TaskModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PriorityOfTask")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("StatusOfTask")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskDateCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskDueDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("TaskIsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("TaskName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("TaskisArchived")
                        .HasColumnType("bit");

                    b.Property<int>("specialistId")
                        .HasColumnType("int");

                    b.Property<string>("specialistName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PriorityOfTask = "High",
                            ProjectId = 3,
                            StatusOfTask = "InProgress",
                            TaskDateCreate = "Build Front End for ChicksFlicks",
                            TaskDescription = "Create the front end for app",
                            TaskDueDate = "05/01/2022",
                            TaskIsDeleted = false,
                            TaskName = "ChickFlicksFrontEnd",
                            TaskisArchived = false,
                            specialistId = 2,
                            specialistName = "An"
                        },
                        new
                        {
                            Id = 2,
                            PriorityOfTask = "High",
                            ProjectId = 3,
                            StatusOfTask = "Completed",
                            TaskDateCreate = "Build Back End for ChicksFlicks",
                            TaskDescription = "Create the back end for app",
                            TaskDueDate = "05/01/2022",
                            TaskIsDeleted = false,
                            TaskName = "ChickFlicksBackEnd",
                            TaskisArchived = false,
                            specialistId = 6,
                            specialistName = "Hector"
                        },
                        new
                        {
                            Id = 3,
                            PriorityOfTask = "Low",
                            ProjectId = 1,
                            StatusOfTask = "InProgress",
                            TaskDateCreate = "Build Front End for Expired?",
                            TaskDescription = "Create the front end for app",
                            TaskDueDate = "05/01/2022",
                            TaskIsDeleted = false,
                            TaskName = "Expired? Front End",
                            TaskisArchived = false,
                            specialistId = 3,
                            specialistName = "Jessie"
                        },
                        new
                        {
                            Id = 4,
                            PriorityOfTask = "Low",
                            ProjectId = 4,
                            StatusOfTask = "InProgress",
                            TaskDateCreate = "Build Back End for BurgerShot",
                            TaskDescription = "Create the back end for BurgerShot",
                            TaskDueDate = "03/18/2022",
                            TaskIsDeleted = false,
                            TaskName = "BurgerShot BackEnd",
                            TaskisArchived = false,
                            specialistId = 2,
                            specialistName = "Bob"
                        });
                });

            modelBuilder.Entity("get_shit_done_webapi.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Hash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("isOwner")
                        .HasColumnType("bit");

                    b.Property<bool>("isRevoked")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("UserInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            Role = "Owner",
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                            Username = "JT",
                            isAdmin = true,
                            isDeleted = false,
                            isOwner = true,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 2,
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            Role = "Admin",
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                            Username = "Angel",
                            isAdmin = true,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 3,
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            Role = "Admin",
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                            Username = "Walaa",
                            isAdmin = true,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 4,
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            Role = "Specialist",
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                            Username = "Henry",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 5,
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            Role = "Specialist",
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                            Username = "Bob",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = true
                        },
                        new
                        {
                            Id = 6,
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            Role = "Specialist",
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                            Username = "Frank",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 7,
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            Role = "Specialist",
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                            Username = "Jacob",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = true
                        },
                        new
                        {
                            Id = 8,
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            Role = "Specialist",
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                            Username = "Jamie",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = true
                        },
                        new
                        {
                            Id = 9,
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            Role = "Specialist",
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                            Username = "John",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 10,
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            Role = "Specialist",
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                            Username = "Spleeter",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 11,
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            Role = "Specialist",
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                            Username = "Jessie",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 12,
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            Role = "Specialist",
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                            Username = "Hector",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = true
                        },
                        new
                        {
                            Id = 13,
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            Role = "Specialist",
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                            Username = "Bobby",
                            isAdmin = false,
                            isDeleted = true,
                            isOwner = false,
                            isRevoked = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
