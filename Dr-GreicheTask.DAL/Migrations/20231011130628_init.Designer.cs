﻿// <auto-generated />
using System;
using Dr_GreicheTask.PL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dr_GreicheTask.DAL.Migrations
{
    [DbContext(typeof(InsuranceDbContext))]
    [Migration("20231011130628_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dr_GreicheTask.PL.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Dr_GreicheTask.PL.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Dr_GreicheTask.PL.Models.InsurancePaper", b =>
                {
                    b.Property<int>("InsurancePaperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InsurancePaperId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("EmploymentContract")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q1Insurances")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Q1InsurancesExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Q6Insurances")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RenewalDate")
                        .HasColumnType("datetime2");

                    b.HasKey("InsurancePaperId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("InsurancePapers");
                });

            modelBuilder.Entity("Dr_GreicheTask.PL.Models.InsuranceRenewal", b =>
                {
                    b.Property<int>("InsuranceRenewalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InsuranceRenewalId"));

                    b.Property<int>("InsurancePaperId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RenewalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RenewalDocument")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InsuranceRenewalId");

                    b.HasIndex("InsurancePaperId");

                    b.ToTable("InsuranceRenewals");
                });

            modelBuilder.Entity("Dr_GreicheTask.PL.Models.Employee", b =>
                {
                    b.HasOne("Dr_GreicheTask.PL.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Dr_GreicheTask.PL.Models.InsurancePaper", b =>
                {
                    b.HasOne("Dr_GreicheTask.PL.Models.Employee", "Employee")
                        .WithMany("InsurancePapers")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Dr_GreicheTask.PL.Models.InsuranceRenewal", b =>
                {
                    b.HasOne("Dr_GreicheTask.PL.Models.InsurancePaper", "InsurancePaper")
                        .WithMany()
                        .HasForeignKey("InsurancePaperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InsurancePaper");
                });

            modelBuilder.Entity("Dr_GreicheTask.PL.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Dr_GreicheTask.PL.Models.Employee", b =>
                {
                    b.Navigation("InsurancePapers");
                });
#pragma warning restore 612, 618
        }
    }
}
