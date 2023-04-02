﻿// <auto-generated />
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
    [Migration("20230402201428_oneToOne2")]
    partial class oneToOne2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                            BurnedKcal = 0.0,
                            Name = "Bench press",
                            Time = 0,
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            BurnedKcal = 0.0,
                            Name = "Squat",
                            Time = 0,
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            BurnedKcal = 0.0,
                            Name = "Deadlift",
                            Time = 0,
                            Type = 0
                        });
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.ExerciseMusclePart", b =>
                {
                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("MusclePartId")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId", "MusclePartId");

                    b.HasIndex("MusclePartId");

                    b.ToTable("ExerciseMuscleParts");

                    b.HasData(
                        new
                        {
                            ExerciseId = 1,
                            MusclePartId = 1
                        },
                        new
                        {
                            ExerciseId = 1,
                            MusclePartId = 3
                        },
                        new
                        {
                            ExerciseId = 2,
                            MusclePartId = 2
                        },
                        new
                        {
                            ExerciseId = 2,
                            MusclePartId = 3
                        },
                        new
                        {
                            ExerciseId = 3,
                            MusclePartId = 3
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

                    b.HasKey("Id");

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

            modelBuilder.Entity("TraingAssistantDAL.Models.TrainingExercise", b =>
                {
                    b.Property<int>("TrainingId")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.HasKey("TrainingId", "ExerciseId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("TrainingExercises");

                    b.HasData(
                        new
                        {
                            TrainingId = 1,
                            ExerciseId = 1
                        },
                        new
                        {
                            TrainingId = 1,
                            ExerciseId = 3
                        },
                        new
                        {
                            TrainingId = 2,
                            ExerciseId = 2
                        },
                        new
                        {
                            TrainingId = 2,
                            ExerciseId = 3
                        },
                        new
                        {
                            TrainingId = 3,
                            ExerciseId = 3
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

            modelBuilder.Entity("TraingAssistantDAL.Models.TrainingPlanTraing", b =>
                {
                    b.Property<int>("TrainingPlanId")
                        .HasColumnType("int");

                    b.Property<int>("TrainingId")
                        .HasColumnType("int");

                    b.HasKey("TrainingPlanId", "TrainingId");

                    b.HasIndex("TrainingId");

                    b.ToTable("TrainingPlanTraings");

                    b.HasData(
                        new
                        {
                            TrainingPlanId = 1,
                            TrainingId = 1
                        },
                        new
                        {
                            TrainingPlanId = 1,
                            TrainingId = 3
                        },
                        new
                        {
                            TrainingPlanId = 2,
                            TrainingId = 2
                        },
                        new
                        {
                            TrainingPlanId = 2,
                            TrainingId = 3
                        },
                        new
                        {
                            TrainingPlanId = 3,
                            TrainingId = 3
                        });
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

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

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 22,
                            Email = "xDD",
                            Height = 0,
                            Name = "Rafał",
                            Password = "xyz",
                            Sex = false,
                            Surname = "Hońca",
                            TargetWeight = 0.0,
                            Tempo = 0.0,
                            Weight = 0.0
                        },
                        new
                        {
                            Id = 2,
                            Age = 22,
                            Email = "xDD",
                            Height = 0,
                            Name = "Marcin",
                            Password = "xyz",
                            Sex = true,
                            Surname = "Misiuna",
                            TargetWeight = 0.0,
                            Tempo = 0.0,
                            Weight = 0.0
                        },
                        new
                        {
                            Id = 3,
                            Age = 33,
                            Email = "xDD",
                            Height = 0,
                            Name = "Mateusz",
                            Password = "xyz",
                            Sex = false,
                            Surname = "Bachowski",
                            TargetWeight = 0.0,
                            Tempo = 0.0,
                            Weight = 0.0
                        });
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.ExerciseMusclePart", b =>
                {
                    b.HasOne("TraingAssistantDAL.Models.Exercise", "Exercise")
                        .WithMany("ExercisesMuscleParts")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TraingAssistantDAL.Models.MusclePart", "MusclePart")
                        .WithMany("ExercisesMuscleParts")
                        .HasForeignKey("MusclePartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("MusclePart");
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.TrainingExercise", b =>
                {
                    b.HasOne("TraingAssistantDAL.Models.Exercise", "Exercise")
                        .WithMany("TrainingExercises")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TraingAssistantDAL.Models.Training", "Training")
                        .WithMany("TrainingExercises")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.TrainingPlanTraing", b =>
                {
                    b.HasOne("TraingAssistantDAL.Models.Training", "Training")
                        .WithMany("TrainingPlanTraings")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TraingAssistantDAL.Models.TrainingPlan", "TrainingPlan")
                        .WithMany("TrainingPlanTraings")
                        .HasForeignKey("TrainingPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Training");

                    b.Navigation("TrainingPlan");
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.User", b =>
                {
                    b.HasOne("TraingAssistantDAL.Models.TrainingPlan", "TrainingPlan")
                        .WithOne("User")
                        .HasForeignKey("TraingAssistantDAL.Models.User", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrainingPlan");
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.Exercise", b =>
                {
                    b.Navigation("ExercisesMuscleParts");

                    b.Navigation("TrainingExercises");
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.MusclePart", b =>
                {
                    b.Navigation("ExercisesMuscleParts");
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.Training", b =>
                {
                    b.Navigation("TrainingExercises");

                    b.Navigation("TrainingPlanTraings");
                });

            modelBuilder.Entity("TraingAssistantDAL.Models.TrainingPlan", b =>
                {
                    b.Navigation("TrainingPlanTraings");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
