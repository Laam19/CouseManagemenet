﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PerformanceCalculator.Business.DbContexts;

namespace PerformanceCalculator.Business.Migrations.migration1
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210918164739_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Audit.CourseAudit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuditData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CourseAudits");
                });

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Audit.TeacherAudit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuditData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TeacherAudits");
                });

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<float>("Credit")
                        .HasColumnType("real");

                    b.Property<string>("DegreeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<string>("Session")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Exam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExamTypeEnum")
                        .HasColumnType("int");

                    b.Property<decimal>("ObtainedMark")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<Guid?>("ResultId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalMark")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("ResultId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Result", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Session")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Designation")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Course", b =>
                {
                    b.HasOne("PerformanceCalculator.Common.Models.Student", "Student")
                        .WithMany("Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("PerformanceCalculator.Common.Models.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Exam", b =>
                {
                    b.HasOne("PerformanceCalculator.Common.Models.Course", "Course")
                        .WithMany("Exams")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PerformanceCalculator.Common.Models.Result", "Result")
                        .WithMany("Exams")
                        .HasForeignKey("ResultId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Course");

                    b.Navigation("Result");
                });

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Result", b =>
                {
                    b.HasOne("PerformanceCalculator.Common.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("PerformanceCalculator.Common.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("PerformanceCalculator.Common.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Course");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Course", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Result", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Student", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("PerformanceCalculator.Common.Models.Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
