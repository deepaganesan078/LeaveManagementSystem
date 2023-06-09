﻿// <auto-generated />
using System;
using Leave.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace project.Migrations
{
    [DbContext(typeof(LeaveDbContext))]
    partial class LeaveDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeTimesheet.MyTask", b =>
                {
                    b.Property<Guid>("taskid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TimesheetId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("end_time")
                        .HasColumnType("time");

                    b.Property<int>("hoursworked")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("start_time")
                        .HasColumnType("time");

                    b.Property<string>("taskname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("taskstatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("taskid");

                    b.HasIndex("TimesheetId");

                    b.ToTable("mytask");
                });

            modelBuilder.Entity("EmployeeTimesheet.Timesheet", b =>
                {
                    b.Property<int>("TimesheetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimesheetId"), 1L, 1);

                    b.Property<int>("Totalhoursworked")
                        .HasColumnType("int");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projectname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TimesheetId");

                    b.ToTable("timesheet");
                });

            modelBuilder.Entity("leave.Models.Domain.Leaves", b =>
                {
                    b.Property<int>("leaveid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("leaveid"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("Numberofdays")
                        .HasColumnType("int");

                    b.Property<DateTime?>("leaveFrom")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("leaveReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("leaveTo")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("leavetype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("leaveid");

                    b.ToTable("leave");
                });

            modelBuilder.Entity("leavebalanceModel.leavebalance", b =>
                {
                    b.Property<int>("Balanceid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Balanceid"), 1L, 1);

                    b.Property<int>("Compensatoryleave")
                        .HasColumnType("int");

                    b.Property<int>("Employeeid")
                        .HasColumnType("int");

                    b.Property<int>("Lossofpay")
                        .HasColumnType("int");

                    b.Property<int>("annualleave")
                        .HasColumnType("int");

                    b.Property<int>("casualleave")
                        .HasColumnType("int");

                    b.Property<int>("sickleave")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Balanceid");

                    b.ToTable("balance");
                });

            modelBuilder.Entity("Leavestatus.LeavestatusTracker", b =>
                {
                    b.Property<int>("statusid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("statusid"), 1L, 1);

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("ParameterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("statusid");

                    b.ToTable("Myleavestatus");
                });

            modelBuilder.Entity("EmployeeTimesheet.MyTask", b =>
                {
                    b.HasOne("EmployeeTimesheet.Timesheet", "mytimesheet")
                        .WithMany("tasks")
                        .HasForeignKey("TimesheetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mytimesheet");
                });

            modelBuilder.Entity("EmployeeTimesheet.Timesheet", b =>
                {
                    b.Navigation("tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
