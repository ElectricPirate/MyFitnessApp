using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFitnessApp.BL.Controller;
using MyFitnessApp.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitnessApp.BL.Controller.Tests
{
    [TestClass()]
    public class ExerciseControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            var userName = Guid.NewGuid().ToString();
            var activityName = Guid.NewGuid().ToString();
            var rnd = new Random();
            var userController = new UserController(userName);
            var exerciseConroller = new ExerciseController(userController.CurrentUser);
            var activity = new Activity(activityName, rnd.Next(10, 50));

            // Act
            exerciseConroller.Add(activity, DateTime.UtcNow, DateTime.UtcNow.AddHours(1));

            // Assert
            Assert.AreEqual(activity.Name, exerciseConroller.Activities.First().Name);
        }
    }
}