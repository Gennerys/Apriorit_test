﻿// <auto-generated />
using System;
using EmployeeManagment.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagment.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200815113510_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagment.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Alex",
                            Salary = 500m,
                            Surname = "Papirnyk"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Vitaliy",
                            Salary = 1000m,
                            Surname = "Tsal"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bohdan",
                            Salary = 1500m,
                            Surname = "Chornobrovkin"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dmitry",
                            Salary = 300m,
                            Surname = "Pikalo"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ann",
                            Salary = 500m,
                            Surname = "Ageeva"
                        });
                });

            modelBuilder.Entity("EmployeeManagment.Data.Models.EmployeePositions", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfDissmisal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeId", "PositionId");

                    b.HasIndex("PositionId");

                    b.ToTable("EmployeePositions");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            PositionId = 2,
                            DateOfDissmisal = new DateTime(2020, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HireDate = new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 1,
                            PositionId = 1,
                            HireDate = new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 2,
                            PositionId = 1,
                            DateOfDissmisal = new DateTime(2020, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HireDate = new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 2,
                            PositionId = 3,
                            HireDate = new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 3,
                            PositionId = 5,
                            DateOfDissmisal = new DateTime(2020, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HireDate = new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 3,
                            PositionId = 6,
                            DateOfDissmisal = new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HireDate = new DateTime(2020, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 4,
                            PositionId = 4,
                            DateOfDissmisal = new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HireDate = new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 5,
                            PositionId = 3,
                            DateOfDissmisal = new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HireDate = new DateTime(2020, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 5,
                            PositionId = 4,
                            HireDate = new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EmployeeManagment.Data.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PositionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PositionName = "Middle dev"
                        },
                        new
                        {
                            Id = 2,
                            PositionName = "Junior dev"
                        },
                        new
                        {
                            Id = 3,
                            PositionName = "Junior QA"
                        },
                        new
                        {
                            Id = 4,
                            PositionName = "Middle QA"
                        },
                        new
                        {
                            Id = 5,
                            PositionName = "Team lead"
                        },
                        new
                        {
                            Id = 6,
                            PositionName = "PM"
                        });
                });

            modelBuilder.Entity("EmployeeManagment.Data.Models.EmployeePositions", b =>
                {
                    b.HasOne("EmployeeManagment.Data.Models.Employee", "Employee")
                        .WithMany("EmployeePositions")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeManagment.Data.Models.Position", "Position")
                        .WithMany("EmployeePositions")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
