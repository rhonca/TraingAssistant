﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraingAssistantDAL.Models;

namespace TraingAssistantDAL.Repositories.Implementation
{
    public interface IExerciseRepository
    {
        List<Exercise> GetExercises();
        Exercise GetExerciseById(int id);
        void InsertExercise(Exercise exercise);
        void DeleteExercise(int id);
        void UpdateExercise(Exercise exercise);
        public void AddMusclePartToExercise(Exercise updatedExercise, int id);
        public void RemoveMusclePartFromExercise(Exercise updatedExercise, int id);
        public void Save();
        public void Dispose();
    }
}
