using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActorRepositoryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

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
            Actor actor1 = new Actor { Id = 1, Name = "Sammy", BirthYear = 2000 };

            //Act & Assert
            actor1.ValidateName();
        }

        // Testing the Validate Year test, excepting an error
        [TestMethod()]
        public void ValidateYearTest_YearIsWrong()
        {
            //Arrange
            Actor actor2 = new Actor { Id = 1, Name = "Emily Thorne", BirthYear = 1985 };

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => actor2.ValidateYear());
        }

        // Now, im testing the first validate method, expecting errors.

        [TestMethod()]

        public void ValidateNameTest_ShouldThrowException()
        {
            //Arrange
            Actor actor3 = new Actor { Id = 1, Name = "David Clarke", BirthYear = 1970 };

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => actor3.ValidateName());
        }

    }
}