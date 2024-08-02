﻿using Forms_Application.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAppTest.ModelTests
{
    [TestFixture]
    public class LocationTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            int expectedLocationID = 1;
            string expectedLocationDescription = "Aisle 1, Shelf 2";

            // Act
            Location location = new Location(expectedLocationID, expectedLocationDescription);

            // Assert
            Assert.That(expectedLocationID, Is.EqualTo(location.LocationID));
            Assert.That(expectedLocationDescription, Is.EqualTo(location.Description));
        }

        [Test]
        public void Setters_ShouldUpdateProperties()
        {
            // Arrange
            Location location = new Location(1, "Aisle 1, Shelf 2");

            int newLocationID = 2;
            string newLocationDescription = "Aisle 2, Shelf 3";

            // Act
            location.LocationID = newLocationID;
            location.Description = newLocationDescription;

            // Assert
            Assert.AreEqual(newLocationID, location.LocationID);
            Assert.AreEqual(newLocationDescription, location.Description);
        }
    }
}
