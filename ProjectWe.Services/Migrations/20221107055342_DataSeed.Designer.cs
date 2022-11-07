﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectWe.Services.Database;

#nullable disable

namespace ProjectWe.Services.Migrations
{
    [DbContext(typeof(_160020Context))]
    [Migration("20221107055342_DataSeed")]
    partial class DataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjectWe.Services.Database.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ActivityID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityId"), 1L, 1);

                    b.Property<string>("ActivityNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DirectBeneficiaries")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<string>("IndirectBeneficiaries")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<string>("Locations")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("OutputId")
                        .HasColumnType("int")
                        .HasColumnName("OutputID");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnName("ProjectID");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("ActivityId");

                    b.HasIndex("OutputId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Budget", b =>
                {
                    b.Property<int>("BudgetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BudgetID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BudgetId"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int")
                        .HasColumnName("ActivityID");

                    b.Property<decimal>("CostPerUnit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<int>("NumberOfUnits")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnName("ProjectID");

                    b.Property<decimal?>("TotalCost")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("decimal(29,2)")
                        .HasComputedColumnSql("([CostPerUnit]*[NumberOfUnits])", false);

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("BudgetId");

                    b.HasIndex("ActivityId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Budgets");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CityID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Objective", b =>
                {
                    b.Property<int>("ObjectiveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ObjectiveID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObjectiveId"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<string>("ObjectiveNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnName("ProjectID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("ObjectiveId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Objectives");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Output", b =>
                {
                    b.Property<int>("OutputId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OutputID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OutputId"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Indicators")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<string>("MeansOfVerification")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ObjectiveId")
                        .HasColumnType("int")
                        .HasColumnName("ObjectiveID");

                    b.Property<string>("OutputNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnName("ProjectID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("OutputId");

                    b.HasIndex("ObjectiveId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Outputs");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProjectID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<int>("CityId")
                        .HasColumnType("int")
                        .HasColumnName("CityID");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("StateMachine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("StatusID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("ProjectId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RoleID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StatusID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex(new[] { "Email" }, "UQ__Users__A9D10534DC1DFCF3")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.UserRole", b =>
                {
                    b.Property<int>("UserRolesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserRolesID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserRolesId"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("UserRolesId")
                        .HasName("PK__UserRole__43D8C0CD6010D0F8");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Vote", b =>
                {
                    b.Property<int>("VoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VoteID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoteId"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<bool>("Positive")
                        .HasColumnType("bit");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnName("ProjectID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("VoteId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Activity", b =>
                {
                    b.HasOne("ProjectWe.Services.Database.Output", "Output")
                        .WithMany("Activities")
                        .HasForeignKey("OutputId")
                        .IsRequired()
                        .HasConstraintName("FK__Activitie__Outpu__6EF57B66");

                    b.HasOne("ProjectWe.Services.Database.Project", "Project")
                        .WithMany("Activities")
                        .HasForeignKey("ProjectId")
                        .IsRequired()
                        .HasConstraintName("FK__Activitie__Proje__6E01572D");

                    b.HasOne("ProjectWe.Services.Database.User", "User")
                        .WithMany("Activities")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Activitie__UserI__6D0D32F4");

                    b.Navigation("Output");

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Budget", b =>
                {
                    b.HasOne("ProjectWe.Services.Database.Activity", "Activity")
                        .WithMany("Budgets")
                        .HasForeignKey("ActivityId")
                        .IsRequired()
                        .HasConstraintName("FK__Budgets__Activit__73BA3083");

                    b.HasOne("ProjectWe.Services.Database.Project", "Project")
                        .WithMany("Budgets")
                        .HasForeignKey("ProjectId")
                        .IsRequired()
                        .HasConstraintName("FK__Budgets__Project__72C60C4A");

                    b.HasOne("ProjectWe.Services.Database.User", "User")
                        .WithMany("Budgets")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Budgets__UserID__71D1E811");

                    b.Navigation("Activity");

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Objective", b =>
                {
                    b.HasOne("ProjectWe.Services.Database.Project", "Project")
                        .WithMany("Objectives")
                        .HasForeignKey("ProjectId")
                        .IsRequired()
                        .HasConstraintName("FK__Objective__Proje__656C112C");

                    b.HasOne("ProjectWe.Services.Database.User", "User")
                        .WithMany("Objectives")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Objective__UserI__6477ECF3");

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Output", b =>
                {
                    b.HasOne("ProjectWe.Services.Database.Objective", "Objective")
                        .WithMany("Outputs")
                        .HasForeignKey("ObjectiveId")
                        .IsRequired()
                        .HasConstraintName("FK__Outputs__Objecti__6A30C649");

                    b.HasOne("ProjectWe.Services.Database.Project", "Project")
                        .WithMany("Outputs")
                        .HasForeignKey("ProjectId")
                        .IsRequired()
                        .HasConstraintName("FK__Outputs__Project__693CA210");

                    b.HasOne("ProjectWe.Services.Database.User", "User")
                        .WithMany("Outputs")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Outputs__UserID__68487DD7");

                    b.Navigation("Objective");

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Project", b =>
                {
                    b.HasOne("ProjectWe.Services.Database.Category", "Category")
                        .WithMany("Projects")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK__Projects__Catego__619B8048");

                    b.HasOne("ProjectWe.Services.Database.City", "City")
                        .WithMany("Projects")
                        .HasForeignKey("CityId")
                        .IsRequired()
                        .HasConstraintName("FK__Projects__City__60A75C0D");

                    b.HasOne("ProjectWe.Services.Database.Status", "Status")
                        .WithMany("Projects")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK__Projects__Status__60A75C0F");

                    b.HasOne("ProjectWe.Services.Database.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Projects__UserID__5FB337D6");

                    b.Navigation("Category");

                    b.Navigation("City");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.UserRole", b =>
                {
                    b.HasOne("ProjectWe.Services.Database.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK__UserRoles__RoleI__5CD6CB2B");

                    b.HasOne("ProjectWe.Services.Database.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__UserRoles__UserI__5BE2A6F2");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Vote", b =>
                {
                    b.HasOne("ProjectWe.Services.Database.Project", "Project")
                        .WithMany("Votes")
                        .HasForeignKey("ProjectId")
                        .IsRequired()
                        .HasConstraintName("FK__Votes__ProjectID__778AC167");

                    b.HasOne("ProjectWe.Services.Database.User", "User")
                        .WithMany("Votes")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Votes__UserID__76969D2E");

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Activity", b =>
                {
                    b.Navigation("Budgets");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Category", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.City", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Objective", b =>
                {
                    b.Navigation("Outputs");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Output", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Project", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Budgets");

                    b.Navigation("Objectives");

                    b.Navigation("Outputs");

                    b.Navigation("Votes");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.Status", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("ProjectWe.Services.Database.User", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Budgets");

                    b.Navigation("Objectives");

                    b.Navigation("Outputs");

                    b.Navigation("Projects");

                    b.Navigation("UserRoles");

                    b.Navigation("Votes");
                });
#pragma warning restore 612, 618
        }
    }
}
