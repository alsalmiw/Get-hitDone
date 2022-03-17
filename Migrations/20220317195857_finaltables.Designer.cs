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
    [Migration("20220317195857_finaltables")]
    partial class finaltables
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

                    b.HasKey("Id");

                    b.ToTable("TaskInfo");
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
                            Hash = "",
                            Role = "Owner",
                            Salt = "",
                            Username = "JT",
                            isAdmin = true,
                            isDeleted = false,
                            isOwner = true,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 2,
                            Hash = "",
                            Role = "Admin",
                            Salt = "",
                            Username = "Angel",
                            isAdmin = true,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 3,
                            Hash = "",
                            Role = "Admin",
                            Salt = "",
                            Username = "Walaa",
                            isAdmin = true,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 4,
                            Hash = "",
                            Role = "Specialist",
                            Salt = "",
                            Username = "Henry",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 5,
                            Hash = "",
                            Role = "Specialist",
                            Salt = "",
                            Username = "Bob",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = true
                        },
                        new
                        {
                            Id = 6,
                            Hash = "",
                            Role = "Specialist",
                            Salt = "",
                            Username = "Frank",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 7,
                            Hash = "",
                            Role = "Specialist",
                            Salt = "",
                            Username = "Jacob",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = true
                        },
                        new
                        {
                            Id = 8,
                            Hash = "",
                            Role = "Specialist",
                            Salt = "",
                            Username = "Jamie",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = true
                        },
                        new
                        {
                            Id = 9,
                            Hash = "",
                            Role = "Specialist",
                            Salt = "",
                            Username = "John",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 10,
                            Hash = "",
                            Role = "Specialist",
                            Salt = "",
                            Username = "Spleeter",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 11,
                            Hash = "",
                            Role = "Specialist",
                            Salt = "",
                            Username = "Jessie",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = false
                        },
                        new
                        {
                            Id = 12,
                            Hash = "",
                            Role = "Specialist",
                            Salt = "",
                            Username = "Hector",
                            isAdmin = false,
                            isDeleted = false,
                            isOwner = false,
                            isRevoked = true
                        },
                        new
                        {
                            Id = 13,
                            Hash = "",
                            Role = "Specialist",
                            Salt = "",
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
