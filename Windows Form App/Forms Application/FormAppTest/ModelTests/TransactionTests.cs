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
    public class TransactionTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            int expectedTransactionID = 1;
            int expectedBoxID = 101;
            int expectedApparelID = 202;
            int expectedQuantityChange = 5;
            DateTime expectedTransactionTime = DateTime.Now;
            TransactionType expectedTransactionType = TransactionType.ADD; // Assuming this is one of the enum values

            // Act
            Transaction transaction = new Transaction(expectedTransactionID, expectedBoxID, expectedApparelID, expectedQuantityChange, expectedTransactionTime, expectedTransactionType);

            // Assert
            Assert.AreEqual(expectedTransactionID, transaction.TransactionID);
            Assert.AreEqual(expectedBoxID, transaction.BoxID);
            Assert.AreEqual(expectedApparelID, transaction.ApparelID);
            Assert.AreEqual(expectedQuantityChange, transaction.QuantityChange);
            Assert.AreEqual(expectedTransactionTime, transaction.TransactionTime);
            Assert.AreEqual(expectedTransactionType, transaction.TransactionType);
        }

        [Test]
        public void Setters_ShouldUpdateProperties()
        {
            // Arrange
            Transaction transaction = new Transaction(1, 101, 202, 5, DateTime.Now, TransactionType.ADD);

            int newTransactionID = 2;
            int newBoxID = 102;
            int newApparelID = 203;
            int newQuantityChange = -3;
            DateTime newTransactionTime = DateTime.Now.AddMinutes(10);
            TransactionType newTransactionType = TransactionType.REMOVE; // Assuming this is one of the enum values

            // Act
            transaction.TransactionID = newTransactionID;
            transaction.BoxID = newBoxID;
            transaction.ApparelID = newApparelID;
            transaction.QuantityChange = newQuantityChange;
            transaction.TransactionTime = newTransactionTime;
            transaction.TransactionType = newTransactionType;

            // Assert
            Assert.AreEqual(newTransactionID, transaction.TransactionID);
            Assert.AreEqual(newBoxID, transaction.BoxID);
            Assert.AreEqual(newApparelID, transaction.ApparelID);
            Assert.AreEqual(newQuantityChange, transaction.QuantityChange);
            Assert.AreEqual(newTransactionTime, transaction.TransactionTime);
            Assert.AreEqual(newTransactionType, transaction.TransactionType);
        }
    }
}
