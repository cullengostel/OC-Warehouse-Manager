
using Forms_Application.Classes.Models;
using Forms_Application.Enums;

namespace FormAppTest.ModelTests
{
    [TestFixture]
    public class ApparelTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            int expectedItemNumber = 1;
            ApparelType expectedType = ApparelType.LongSleeve; // Assuming Shirt is a value in the ApparelType enum
            string expectedColor = "Red";
            string expectedSize = "M";
            string expectedStyle = "Casual";
            int expectedQuantity = 10;

            // Act
            Apparel apparel = new(expectedItemNumber, expectedType, expectedColor, expectedSize, expectedStyle, expectedQuantity);

            // Assert
            Assert.That(apparel.ItemNumber, Is.EqualTo(expectedItemNumber));
            Assert.That(apparel.Type, Is.EqualTo(expectedType));
            Assert.That(apparel.Color, Is.EqualTo(expectedColor));
            Assert.That(apparel.Size, Is.EqualTo(expectedSize));
            Assert.That(apparel.Style, Is.EqualTo(expectedStyle));
            Assert.That(apparel.Quantity, Is.EqualTo(expectedQuantity));
        }

        [Test]
        public void Setters_ShouldUpdateProperties()
        {
            // Arrange
            Apparel apparel = new(1, ApparelType.LongSleeve, "Red", "M", "Casual", 10);

            int newItemNumber = 2;
            ApparelType newType = ApparelType.ShortSleeve; // Assuming Pants is a value in the ApparelType enum
            string newColor = "Blue";
            string newSize = "L";
            string newStyle = "Formal";
            int newQuantity = 20;

            // Act
            apparel.ItemNumber = newItemNumber;
            apparel.Type = newType;
            apparel.Color = newColor;
            apparel.Size = newSize;
            apparel.Style = newStyle;
            apparel.Quantity = newQuantity;

            // Assert
            Assert.That(apparel.ItemNumber, Is.EqualTo(newItemNumber));
            Assert.That(apparel.Type, Is.EqualTo(newType));
            Assert.That(apparel.Color, Is.EqualTo(newColor));
            Assert.That(apparel.Size, Is.EqualTo(newSize));
            Assert.That(apparel.Style, Is.EqualTo(newStyle));
            Assert.That(apparel.Quantity, Is.EqualTo(newQuantity));
        }


    }
}