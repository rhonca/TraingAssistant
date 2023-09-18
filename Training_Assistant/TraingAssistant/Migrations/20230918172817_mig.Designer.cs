﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TraingAssistantDAL.DataAccess;

#nullable disable

namespace TraingAssistantDAL.Migrations
{
    [DbContext(typeof(TrainingAssistantContext))]
    [Migration("20230918172817_mig")]
    partial class mig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExerciseMusclePart", b =>
                {
                    b.Property<int>("ExercisesId")
                        .HasColumnType("int");

                    b.Property<int>("MusclePartsId")
                        .HasColumnType("int");

                    b.HasKey("ExercisesId", "MusclePartsId");

                    b.HasIndex("MusclePartsId");

                    b.ToTable("MusclePartExercise", (string)null);
                });

            modelBuilder.Entity("ExerciseTraining", b =>
                {
                    b.Property<int>("ExercisesId")
                        .HasColumnType("int");

                    b.Property<int>("TrainingsId")
                        .HasColumnType("int");

                    b.HasKey("ExercisesId", "TrainingsId");

                    b.HasIndex("TrainingsId");

                    b.ToTable("ExerciseTraining", (string)null);
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("BurnedKcal")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BurnedKcal = 10.0,
                            Name = "Bench press",
                            Time = 5,
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            BurnedKcal = 20.0,
                            Name = "Squat",
                            Time = 10,
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            BurnedKcal = 30.0,
                            Name = "Deadlift",
                            Time = 15,
                            Type = 0
                        });
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.MusclePart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MuscleParts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Chest"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Legs"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Back"
                        });
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainingPlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainingPlanId");

                    b.ToTable("Trainings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Days = 0,
                            Name = "Endurance training"
                        },
                        new
                        {
                            Id = 2,
                            Days = 0,
                            Name = "Acrobatic training"
                        },
                        new
                        {
                            Id = 3,
                            Days = 0,
                            Name = "Tabata training"
                        });
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.TrainingPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TrainingPlans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Weight loss",
                            UserId = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mass gain",
                            UserId = 0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ninja warrior",
                            UserId = 0
                        });
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TargetWeight")
                        .HasColumnType("float");

                    b.Property<double>("Tempo")
                        .HasColumnType("float");

                    b.Property<int?>("TrainingPlanId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("TrainingPlanId")
                        .IsUnique()
                        .HasFilter("[TrainingPlanId] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 22,
                            Email = "admin@gmail.com",
                            Height = 183,
                            IsAdmin = true,
                            Name = "Bożena",
                            Password = "admin",
                            Sex = false,
                            Surname = "Hońca",
                            TargetWeight = 0.0,
                            Tempo = 0.0,
                            Weight = 65.0
                        },
                        new
                        {
                            Id = 3,
                            Age = 33,
                            Email = "user@gmail.com",
                            Height = 170,
                            IsAdmin = false,
                            Name = "Mateusz",
                            Password = "user",
                            Sex = false,
                            Surname = "Bachowski",
                            TargetWeight = 0.0,
                            Tempo = 0.0,
                            Weight = 45.0
                        });
                });

            modelBuilder.Entity("ExerciseMusclePart", b =>
                {
                    b.HasOne("TraingAssistantDAL.Models.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TraingAssistantDAL.Models.MusclePart", null)
                        .WithMany()
                        .HasForeignKey("MusclePartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExerciseTraining", b =>
                {
                    b.HasOne("TraingAssistantDAL.Models.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TraingAssistantDAL.Models.Training", null)
                        .WithMany()
                        .HasForeignKey("TrainingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.Training", b =>
                {
                    b.HasOne("TraingAssistantDAL.Models.TrainingPlan", "TrainingPlan")
                        .WithMany("Trainings")
                        .HasForeignKey("TrainingPlanId");

                    b.Navigation("TrainingPlan");
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.User", b =>
                {
                    b.HasOne("TraingAssistantDAL.Models.TrainingPlan", "TrainingPlan")
                        .WithOne("User")
                        .HasForeignKey("TraingAssistantDAL.Models.User", "TrainingPlanId");

                    b.Navigation("TrainingPlan");
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.TrainingPlan", b =>
                {
                    b.Navigation("Trainings");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}