﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessObject.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240402202803_backToMessage")]
    partial class backToMessage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AttendanceStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("LeaveTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WorkingStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LeaveTypeId");

                    b.HasIndex("WorkingStatusId");

                    b.ToTable("AttendanceStatuses");
                });

            modelBuilder.Entity("BusinessObject.Model.Wifi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BSSID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Wifis");
                });

            modelBuilder.Entity("DepartmentHoliday", b =>
                {
                    b.Property<Guid>("HolidayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HolidayName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRecurring")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("HolidayId");

                    b.ToTable("DepartmentHolidays");
                });

            modelBuilder.Entity("DepartmentHolidayException", b =>
                {
                    b.Property<Guid>("ExceptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExceptionDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HolidayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ExceptionId");

                    b.HasIndex("HolidayId");

                    b.ToTable("DepartmentHolidayExceptions");
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("EmployeeStatus")
                        .HasColumnType("int");

                    b.Property<string>("EmploymentType")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("FullTime");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("LeaveSetting", b =>
                {
                    b.Property<Guid>("LeaveSettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsManagerAssigned")
                        .HasColumnType("bit");

                    b.Property<string>("MaxDateLeave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeaveSettingId");

                    b.ToTable("LeaveSettings");
                });

            modelBuilder.Entity("LeaveType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("AllowedDays")
                        .HasColumnType("int");

                    b.Property<bool>("CanCarryForward")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LeaveCycle")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TotalBalance")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LeaveTypes");
                });

            modelBuilder.Entity("Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeIdLastDecider")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeSendRequestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("PathAttachmentFile")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid?>("RequestLeaveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RequestOverTimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RequestWorkTimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmitedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("requestType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeSendRequestId");

                    b.HasIndex("RequestLeaveId");

                    b.HasIndex("RequestOverTimeId");

                    b.HasIndex("RequestWorkTimeId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("RequestLeave", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("LeaveTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("RequestLeaves");
                });

            modelBuilder.Entity("RequestOverTime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfOverTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FromHour")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("NumberOfHour")
                        .HasColumnType("float");

                    b.Property<DateTime>("ToHour")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("WorkingStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WorkingStatusId");

                    b.ToTable("RequestOverTimes");
                });

            modelBuilder.Entity("RequestWorkTime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateOfSlot")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float?>("NumberOfComeLateHour")
                        .HasColumnType("real");

                    b.Property<float?>("NumberOfLeaveEarlyHour")
                        .HasColumnType("real");

                    b.Property<string>("RealHourEnd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RealHourStart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("WorkslotEmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WorkslotEmployeeId");

                    b.ToTable("RequestWorkTimes");
                });

            modelBuilder.Entity("RiskPerformanceEmployee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("RiskPerformanceSettingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ViolationJSON")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RiskPerformanceSettingId");

                    b.ToTable("RiskPerformanceEmployees");
                });

            modelBuilder.Entity("RiskPerformanceSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateSet")
                        .HasColumnType("datetime2");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("RiskPerformanceSettings");
                });

            modelBuilder.Entity("Role", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("WorkTrackId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WorkTrackId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("UserAccount", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SaltPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.HasIndex("RoleID");

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("WorkDateSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DateStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("WorkDateSettings");
                });

            modelBuilder.Entity("WorkingStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("WorkingStatuses");
                });

            modelBuilder.Entity("WorkPermissionSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkPermissionSettings");
                });

            modelBuilder.Entity("Workslot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfSlot")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FromHour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMorning")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToHour")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Workslots");
                });

            modelBuilder.Entity("WorkslotEmployee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AttendanceStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CheckInTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckOutTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("RequestLeaveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkslotId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AttendanceStatusId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RequestLeaveId");

                    b.HasIndex("WorkslotId");

                    b.ToTable("WorkslotEmployees");
                });

            modelBuilder.Entity("WorkTimeSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FromHourAfternoon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromHourMorning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ToHourAfternoon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToHourMorning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkTimeSettings");
                });

            modelBuilder.Entity("WorkTrackSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("LeaveSettingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RiskPerfomanceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WorkDateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WorkTimeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LeaveSettingId");

                    b.HasIndex("RiskPerfomanceId");

                    b.HasIndex("WorkDateId");

                    b.HasIndex("WorkTimeId");

                    b.ToTable("WorkTrackSettings");
                });

            modelBuilder.Entity("AttendanceStatus", b =>
                {
                    b.HasOne("LeaveType", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId");

                    b.HasOne("WorkingStatus", "WorkingStatus")
                        .WithMany()
                        .HasForeignKey("WorkingStatusId");

                    b.Navigation("LeaveType");

                    b.Navigation("WorkingStatus");
                });

            modelBuilder.Entity("DepartmentHolidayException", b =>
                {
                    b.HasOne("DepartmentHoliday", "DepartmentHoliday")
                        .WithMany()
                        .HasForeignKey("HolidayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartmentHoliday");
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.HasOne("Team", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Request", b =>
                {
                    b.HasOne("Employee", "EmployeeSendRequest")
                        .WithMany()
                        .HasForeignKey("EmployeeSendRequestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RequestLeave", "RequestLeave")
                        .WithMany()
                        .HasForeignKey("RequestLeaveId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RequestOverTime", "RequestOverTime")
                        .WithMany()
                        .HasForeignKey("RequestOverTimeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RequestWorkTime", "RequestWorkTime")
                        .WithMany()
                        .HasForeignKey("RequestWorkTimeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("EmployeeSendRequest");

                    b.Navigation("RequestLeave");

                    b.Navigation("RequestOverTime");

                    b.Navigation("RequestWorkTime");
                });

            modelBuilder.Entity("RequestLeave", b =>
                {
                    b.HasOne("LeaveType", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LeaveType");
                });

            modelBuilder.Entity("RequestOverTime", b =>
                {
                    b.HasOne("WorkingStatus", "WorkingStatus")
                        .WithMany()
                        .HasForeignKey("WorkingStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkingStatus");
                });

            modelBuilder.Entity("RequestWorkTime", b =>
                {
                    b.HasOne("WorkslotEmployee", "WorkslotEmployee")
                        .WithMany()
                        .HasForeignKey("WorkslotEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkslotEmployee");
                });

            modelBuilder.Entity("RiskPerformanceEmployee", b =>
                {
                    b.HasOne("Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RiskPerformanceSetting", "RiskPerformanceSetting")
                        .WithMany()
                        .HasForeignKey("RiskPerformanceSettingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("RiskPerformanceSetting");
                });

            modelBuilder.Entity("Team", b =>
                {
                    b.HasOne("WorkTrackSetting", "WorkTrackSetting")
                        .WithMany()
                        .HasForeignKey("WorkTrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkTrackSetting");
                });

            modelBuilder.Entity("UserAccount", b =>
                {
                    b.HasOne("Employee", "Employee")
                        .WithOne("UserAccount")
                        .HasForeignKey("UserAccount", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Workslot", b =>
                {
                    b.HasOne("Team", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WorkslotEmployee", b =>
                {
                    b.HasOne("AttendanceStatus", "AttendanceStatus")
                        .WithMany()
                        .HasForeignKey("AttendanceStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RequestLeave", null)
                        .WithMany("WorkslotEmployees")
                        .HasForeignKey("RequestLeaveId");

                    b.HasOne("Workslot", "Workslot")
                        .WithMany()
                        .HasForeignKey("WorkslotId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AttendanceStatus");

                    b.Navigation("Employee");

                    b.Navigation("Workslot");
                });

            modelBuilder.Entity("WorkTrackSetting", b =>
                {
                    b.HasOne("LeaveSetting", "LeaveSetting")
                        .WithMany()
                        .HasForeignKey("LeaveSettingId");

                    b.HasOne("RiskPerformanceSetting", "RiskPerfomanceSetting")
                        .WithMany()
                        .HasForeignKey("RiskPerfomanceId");

                    b.HasOne("WorkDateSetting", "WorkDateSetting")
                        .WithMany()
                        .HasForeignKey("WorkDateId");

                    b.HasOne("WorkTimeSetting", "WorkTimeSetting")
                        .WithMany()
                        .HasForeignKey("WorkTimeId");

                    b.Navigation("LeaveSetting");

                    b.Navigation("RiskPerfomanceSetting");

                    b.Navigation("WorkDateSetting");

                    b.Navigation("WorkTimeSetting");
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.Navigation("UserAccount")
                        .IsRequired();
                });

            modelBuilder.Entity("RequestLeave", b =>
                {
                    b.Navigation("WorkslotEmployees");
                });

            modelBuilder.Entity("Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Team", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
