﻿// <auto-generated />
using System;
using Asystent_Treningowy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace TrainingAssistant.Migrations
{
    [DbContext(typeof(DbTrainingAssistant))]
    [Migration("20230328173600_Rmigracja")]
    partial class Rmigracja
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Asystent_Treningowy.Models.Excercise", b =>
                {
                    b.Property<int>("IdExcercise")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdExcercise"));

                    b.Property<double>("BurnedKcal")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("IdExcercise");

                    b.ToTable("Excercise");

                    b.HasData(
                        new
                        {
                            IdExcercise = 1,
                            BurnedKcal = 0.38,
                            Name = "Squat",
                            Time = 3,
                            Type = 4
                        },
                        new
                        {
                            IdExcercise = 2,
                            BurnedKcal = 0.28999999999999998,
                            Name = "Push-up",
                            Time = 2,
                            Type = 1
                        });
                });

            modelBuilder.Entity("Asystent_Treningowy.Models.MusclePart", b =>
                {
                    b.Property<int>("IdPart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPart"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPart");

                    b.ToTable("MusclePart");

                    b.HasData(
                        new
                        {
                            IdPart = 1,
                            Name = "Chest"
                        },
                        new
                        {
                            IdPart = 2,
                            Name = "Legs"
                        });
                });

            modelBuilder.Entity("Asystent_Treningowy.Models.Training", b =>
                {
                    b.Property<int>("IdTraining")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTraining"));

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Training")
                        .HasColumnType("int");

                    b.HasKey("IdTraining");

                    b.HasIndex("Training");

                    b.ToTable("Training");

                    b.HasData(
                        new
                        {
                            IdTraining = 1,
                            Days = 3,
                            Name = "Endurance training"
                        },
                        new
                        {
                            IdTraining = 2,
                            Days = 4,
                            Name = "Acrobatic training"
                        });
                });

            modelBuilder.Entity("Asystent_Treningowy.Models.TrainingPlan", b =>
                {
                    b.Property<int>("IdPlan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPlan"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPlan");

                    b.ToTable("TrainingPlan");
                });

            modelBuilder.Entity("Asystent_Treningowy.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TargetWeight")
                        .HasColumnType("float");

                    b.Property<double>("Tempo")
                        .HasColumnType("float");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("IdUser");

                    b.ToTable("User");
                });

            modelBuilder.Entity("TrainingAssistant.Models.ExerciseMuscle", b =>
                {
                    b.Property<int>("IdExercise")
                        .HasColumnType("int");

                    b.Property<int>("IdMusclePart")
                        .HasColumnType("int");

                    b.HasKey("IdExercise", "IdMusclePart");

                    b.HasIndex("IdMusclePart");

                    b.ToTable("ExerciseMuscle");

                    b.HasData(
                        new
                        {
                            IdExercise = 1,
                            IdMusclePart = 2
                        },
                        new
                        {
                            IdExercise = 2,
                            IdMusclePart = 1
                        });
                });

            modelBuilder.Entity("TrainingAssistant.Models.TrainingExercise", b =>
                {
                    b.Property<int>("IdTraining")
                        .HasColumnType("int");

                    b.Property<int>("IdExcercise")
                        .HasColumnType("int");

                    b.HasKey("IdTraining", "IdExcercise");

                    b.HasIndex("IdExcercise");

                    b.ToTable("TrainingExercise");

                    b.HasData(
                        new
                        {
                            IdTraining = 1,
                            IdExcercise = 2
                        },
                        new
                        {
                            IdTraining = 2,
                            IdExcercise = 1
                        });
                });

            modelBuilder.Entity("Asystent_Treningowy.Models.Training", b =>
                {
                    b.HasOne("Asystent_Treningowy.Models.TrainingPlan", null)
                        .WithMany("Trainings")
                        .HasForeignKey("Training");
                });

            modelBuilder.Entity("TrainingAssistant.Models.ExerciseMuscle", b =>
                {
                    b.HasOne("Asystent_Treningowy.Models.Excercise", "excercise")
                        .WithMany("ExerciseMuscle")
                        .HasForeignKey("IdExercise")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Asystent_Treningowy.Models.MusclePart", "musclePart")
                        .WithMany("ExerciseMuscle")
                        .HasForeignKey("IdMusclePart")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("excercise");

                    b.Navigation("musclePart");
                });

            modelBuilder.Entity("TrainingAssistant.Models.TrainingExercise", b =>
                {
                    b.HasOne("Asystent_Treningowy.Models.Excercise", "exercise")
                        .WithMany("TrainingExercise")
                        .HasForeignKey("IdExcercise")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Asystent_Treningowy.Models.Training", "training")
                        .WithMany("TrainingExercise")
                        .HasForeignKey("IdTraining")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("exercise");

                    b.Navigation("training");
                });

            modelBuilder.Entity("Asystent_Treningowy.Models.Excercise", b =>
                {
                    b.Navigation("ExerciseMuscle");

                    b.Navigation("TrainingExercise");
                });

            modelBuilder.Entity("Asystent_Treningowy.Models.MusclePart", b =>
                {
                    b.Navigation("ExerciseMuscle");
                });

            modelBuilder.Entity("Asystent_Treningowy.Models.Training", b =>
                {
                    b.Navigation("TrainingExercise");
                });

            modelBuilder.Entity("Asystent_Treningowy.Models.TrainingPlan", b =>
                {
                    b.Navigation("Trainings");
                });
#pragma warning restore 612, 618
        }
    }
}
