using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActorRepositoryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorRepositoryLib.Tests
{
    [TestClass()]
    public class ActorTests
    {
   
        // First, im testing the Name validation test, where im NOT expecting an error.
        [TestMethod()]
        public void ValidateNameTest_NameIsValid()
        {
            //Arrange
            var Actor = new Actor(1, "Sammy", 1985);

            //Act & Assert
            Actor.ValidateName();
        }

        // Testing the Validate Year test, excepting an error
        [TestMethod()]
        public void ValidateYearTest_YearIsWrong()
        {
            //Arrange
            var Actor = new Actor(1, "John", 1815);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => Actor.ValidateYear());
        }

        // Now, im testing the first validate method,  expecting errors.

        [TestMethod()]
        
        public void ValidateNameTest_ShouldThrowException()
        {
            //Arrange
            var Actor = new Actor(1, "Jo", 2001);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => Actor.ValidateName());
        }

    }
}