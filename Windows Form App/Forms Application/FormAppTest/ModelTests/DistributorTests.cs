using Forms_Application.Classes.Controllers;
using Forms_Application.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FormAppTest.ModelTests
{
    [TestFixture]
    public class DistributorTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            int expectedID = 1;
            string expectedName = "Distributor A";
            string expectedContactInfo = "contact@distributor.com";

            // Act
            Distributor distributor = new Distributor(expectedID, expectedName, expectedContactInfo);

            // Assert
            Assert.AreEqual(expectedID, distributor.DistributorID);
            Assert.AreEqual(expectedName, distributor.Name);
            Assert.AreEqual(expectedContactInfo, distributor.ContactInfo);
        }

        [Test]
        public void Setters_ShouldUpdateProperties()
        {
            // Arrange
            Distributor distributor = new Distributor(1, "Distributor A", "contact@distributor.com");

            int newID = 2;
            string newName = "Distributor B";
            string newContactInfo = "contactB@distributor.com";

            // Act
            distributor.DistributorID = newID; // This will need to be a property if you want to use a setter.
            distributor.Name = newName;
            distributor.ContactInfo = newContactInfo;

            // Assert
            Assert.AreEqual(newID, distributor.DistributorID);
            Assert.AreEqual(newName, distributor.Name);
            Assert.AreEqual(newContactInfo, distributor.ContactInfo);
        }

        [Test]
        public void Controller_ShouldLoadList()
        {
            // Arrange
            DistributorController dc = new();
            Distributor distro1 = dc.GetDistributor(3);
            int expectedID = 3;
            string expectedName = "Distributor Three";
            string expectedContact = "contact3@distributor.com";

            // Assert
            Assert.That(expectedName, Is.EqualTo(distro1.Name));
        }
    }
}
