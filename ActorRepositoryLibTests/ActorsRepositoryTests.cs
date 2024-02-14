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
    public class ActorsRepositoryTests
    {
        [TestMethod()]
        public void GetTest()
        {
            // Arrange
            ActorsRepository repository = new ActorsRepository();
            // Act
            var result = repository.Get();
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            ActorsRepository repository = new ActorsRepository();
            Actor actor = new Actor(1, "Test", 1999);
            // Act
            var result = repository.Add(actor);
            // Assert
            Assert.IsNotNull(result);
            
        }

        [TestMethod()]
        public void DeleteTest()
        {
            // Arrange
            ActorsRepository repository = new ActorsRepository();
            Actor actor = new Actor(1, "Test", 1999);

            // Act
            var result = repository.Delete(1);

            // Assert
            Assert.IsNotNull(result);
        }

    }
}