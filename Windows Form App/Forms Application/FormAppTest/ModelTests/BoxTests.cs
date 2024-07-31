using Forms_Application.Classes.Models;
using Forms_Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAppTest.ModelTests
{
    [TestFixture]
    public class BoxTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            int expectedBoxID = 1;
            int expectedLocationID = 101;
            var expectedContents = new List<Apparel>
            {
                new Apparel(1, ApparelType.ShortSleeve, "Red", "M", "Casual", 5),
                new Apparel(2, ApparelType.LongSleeve, "Blue", "L", "Formal", 3)
            };

            // Act
            Box box = new Box(expectedBoxID, expectedLocationID, expectedContents);

            // Assert
            Assert.That(expectedBoxID, Is.EqualTo(box.BoxID));
            Assert.AreEqual(expectedLocationID, box.LocationID);
            Assert.AreEqual(expectedContents, box.Contents);
        }

        [Test]
        public void Setters_ShouldUpdateProperties()
        {
            // Arrange
            var box = new Box(1, 101, new List<Apparel>());

            int newBoxID = 2;
            int newLocationID = 102;
            var newContents = new List<Apparel>
            {
                new Apparel(3, ApparelType.ShortSleeve, "Black", "XL", "Winter", 2)
            };

            // Act
            box.BoxID = newBoxID;
            box.LocationID = newLocationID;
            box.Contents = newContents;

            // Assert
            Assert.AreEqual(newBoxID, box.BoxID);
            Assert.AreEqual(newLocationID, box.LocationID);
            Assert.AreEqual(newContents, box.Contents);
        }

        [Test]
        public void GetTotalQuantity_ShouldReturnCorrectTotal()
        {
            // Arrange
            var contents = new List<Apparel>
            {
                new Apparel(1, ApparelType.ShortSleeve, "Red", "M", "Casual", 5),
                new Apparel(2, ApparelType.LongSleeve, "Blue", "L", "Formal", 3)
            };
            var box = new Box(1, 101, contents);
            int expectedTotalQuantity = 8;

            // Act
            int totalQuantity = box.GetTotalQuantity();

            // Assert
            Assert.AreEqual(expectedTotalQuantity, totalQuantity);
        }
    }
}
