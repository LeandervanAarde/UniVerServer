﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UniVerServer;
using UniVerServer.Models;

#nullable disable

namespace UniVerServer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UniVerServer.Models.Address", b =>
                {
                    b.Property<int>("address_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("address_id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("address_area")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("address_city")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("address_phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("address_province")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("address_zipcode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("address_id");

                    b.ToTable("people_address");
                });

            modelBuilder.Entity("UniVerServer.Models.CourseEnrollments", b =>
                {
                    b.Property<int>("enrollment_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("enrollment_id"));

                    b.Property<DateTime>("course_start")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("student_id")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("subject_id")
                        .HasColumnType("integer");

                    b.HasKey("enrollment_id");

                    b.HasIndex("subject_id");

                    b.ToTable("course_enrollments");
                });

            modelBuilder.Entity("UniVerServer.Models.Events", b =>
                {
                    b.Property<int>("event_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("event_id"));

                    b.Property<DateTime>("event_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("event_description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("event_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("person_system_identifier")
                        .HasColumnType("integer");

                    b.HasKey("event_id");

                    b.HasIndex("person_system_identifier");

                    b.ToTable("events");
                });

            modelBuilder.Entity("UniVerServer.Models.MadePayments", b =>
                {
                    b.Property<int>("payment_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("payment_id"));

                    b.Property<int>("payment_amount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("payment_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("person_system_identifier")
                        .HasColumnType("integer");

                    b.HasKey("payment_id");

                    b.HasIndex("person_system_identifier");

                    b.ToTable("student_payments");
                });

            modelBuilder.Entity("UniVerServer.Models.OutStandingStudentFees", b =>
                {
                    b.Property<int>("fee_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("fee_id"));

                    b.Property<int>("outstanding_amount")
                        .HasColumnType("integer");

                    b.Property<int>("person_system_identifier")
                        .HasColumnType("integer");

                    b.HasKey("fee_id");

                    b.HasIndex("person_system_identifier");

                    b.ToTable("outstanding_student_fees");
                });

            modelBuilder.Entity("UniVerServer.Models.People", b =>
                {
                    b.Property<int>("person_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("person_id"));

                    b.Property<DateTime>("added_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("address")
                        .HasColumnType("integer");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<bool>("person_active")
                        .HasColumnType("boolean");

                    b.Property<int>("person_credits")
                        .HasColumnType("integer");

                    b.Property<string>("person_email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<string>("person_password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("person_system_identifier")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("role")
                        .HasColumnType("integer");

                    b.HasKey("person_id");

                    b.ToTable("people");
                });
            modelBuilder.Entity("UniVerServer.Models.Roles", b =>
                {
                    b.Property<int>("role_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("role_id"));

                    b.Property<bool>("can_access")
                        .HasColumnType("boolean");

                    b.Property<string>("role_name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("role_id");

                    b.ToTable("people_roles");
                });

            modelBuilder.Entity("UniVerServer.Models.StudentCourses", b =>
                {
                    b.Property<string>("grade_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<int>("facilitator_id")
                        .HasColumnType("integer");

                    b.Property<int>("grade")
                        .HasColumnType("integer");

                    b.Property<int>("student_id")
                        .HasColumnType("integer");

                    b.Property<int>("subject_id")
                        .HasColumnType("integer");

                    b.HasKey("grade_id");

                    b.HasIndex("facilitator_id");

                    b.HasIndex("student_id");

                    b.HasIndex("subject_id");

                    b.ToTable("student_grades");
                });

            modelBuilder.Entity("UniVerServer.Models.Subjects", b =>
                {
                    b.Property<int>("subject_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("subject_id"));

                    b.Property<int>("person_id")
                        .HasColumnType("integer");

                    b.Property<string>("subjectImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("subject_class_amount")
                        .HasColumnType("integer");

                    b.Property<int>("subject_class_runtiem")
                        .HasColumnType("integer");

                    b.Property<string>("subject_code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("subject_color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("subject_cost")
                        .HasColumnType("integer");

                    b.Property<int>("subject_credits")
                        .HasColumnType("integer");

                    b.Property<string>("subject_description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("subject_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("subject_id");

                    b.HasIndex("person_id");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("UniVerServer.Models.CourseEnrollments", b =>
                {
                    b.HasOne("UniVerServer.Models.Subjects", "Subjects")
                        .WithMany()
                        .HasForeignKey("subject_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("UniVerServer.Models.Events", b =>
                {
                    b.HasOne("UniVerServer.Models.People", "staff_organiser")
                        .WithMany()
                        .HasForeignKey("person_system_identifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("staff_organiser");
                });

            modelBuilder.Entity("UniVerServer.Models.MadePayments", b =>
                {
                    b.HasOne("UniVerServer.Models.People", "student_id")
                        .WithMany()
                        .HasForeignKey("person_system_identifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("student_id");
                });

            modelBuilder.Entity("UniVerServer.Models.OutStandingStudentFees", b =>
                {
                    b.HasOne("UniVerServer.Models.People", "student_id")
                        .WithMany()
                        .HasForeignKey("person_system_identifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("student_id");
                });

            modelBuilder.Entity("UniVerServer.Models.StudentCourses", b =>
                {
                    b.HasOne("UniVerServer.Models.People", "facilitator")
                        .WithMany()
                        .HasForeignKey("facilitator_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniVerServer.Models.People", "student")
                        .WithMany()
                        .HasForeignKey("student_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniVerServer.Models.Subjects", "subject")
                        .WithMany()
                        .HasForeignKey("subject_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("facilitator");

                    b.Navigation("student");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("UniVerServer.Models.Subjects", b =>
                {
                    b.HasOne("UniVerServer.Models.People", "lecturer_id")
                        .WithMany()
                        .HasForeignKey("person_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("lecturer_id");
                });
#pragma warning restore 612, 618
        }
    }
}
