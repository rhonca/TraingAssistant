﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraingAssistantDAL.Models;
using TrainingAssistantBLL.BusinessLogic;

namespace TrainingAssistantTests.ControllersTests
{
    internal class ExerciseBLLMock : IExerciseBs
    {
        public double burnedPerHour(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteExercise(int id)
        {
            throw new NotImplementedException();
        }

        public Exercise GetExerciseById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Exercise> GetExercises()
        {
            throw new NotImplementedException();
        }

        public void InsertExercise(Exercise exercise)
        {
            throw new NotImplementedException();
        }

        public void UpdateExercise(Exercise exercise)
        {
            throw new NotImplementedException();
        }
    }
}
