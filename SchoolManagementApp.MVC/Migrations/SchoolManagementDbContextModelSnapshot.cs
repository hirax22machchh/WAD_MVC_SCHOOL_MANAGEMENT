﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagementApp.MVC.Data;

#nullable disable

namespace SchoolManagementApp.MVC.Migrations
{
    [DbContext(typeof(SchoolManagementDbContext))]
    partial class SchoolManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolManagementApp.MVC.Data.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("LecturerId")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("Time")
                        .HasColumnType("time");

                    b.HasKey("Id")
                        .HasName("PK__Classes__3214EC07E92ADF10");

                    b.HasIndex("CourseId");

                    b.HasIndex("LecturerId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("SchoolManagementApp.MVC.Data.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int?>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Courses__3214EC0713D9C98E");

                    b.HasIndex(new[] { "Code" }, "UQ__Courses__A25C5AA7BA5557BD")
                        .IsUnique()
                        .HasFilter("[Code] IS NOT NULL");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SchoolManagementApp.MVC.Data.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Enrollme__3214EC07ADD74D4F");

                    b.HasIndex("ClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("SchoolManagementApp.MVC.Data.Lecturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Lecturer__3214EC071380BF1D");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("SchoolManagementApp.MVC.Data.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Students__3214EC074CCF9327");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolManagementApp.MVC.Data.Class", b =>
                {
                    b.HasOne("SchoolManagementApp.MVC.Data.Course", "Course")
                        .WithMany("Classes")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK__Classes__CourseI__3E52440B");

                    b.HasOne("SchoolManagementApp.MVC.Data.Lecturer", "Lecturer")
                        .WithMany("Classes")
                        .HasForeignKey("LecturerId")
                        .HasConstraintName("FK__Classes__Lecture__3D5E1FD2");

                    b.Navigation("Course");

                    b.Navigation("Lecturer");
                });

            modelBuilder.Entity("SchoolManagementApp.MVC.Data.Enrollment", b =>
                {
                    b.HasOne("SchoolManagementApp.MVC.Data.Class", "Class")
                        .WithMany("Enrollments")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK__Enrollmen__Class__4222D4EF");

                    b.HasOne("SchoolManagementApp.MVC.Data.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK__Enrollmen__Stude__412EB0B6");

                    b.Navigation("Class");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SchoolManagementApp.MVC.Data.Class", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("SchoolManagementApp.MVC.Data.Course", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("SchoolManagementApp.MVC.Data.Lecturer", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("SchoolManagementApp.MVC.Data.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
