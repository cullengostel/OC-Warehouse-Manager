using Forms_Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Application.Classes.Models
{
    //Author:  Cullen Gostel
    //Version: 07/25/2024
    //Transaction class, stores transactions to and from SQL database
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int BoxID { get; set; }
        public int ApparelID { get; set; }
        public int QuantityChange { get; set; }
        public DateTime TransactionTime { get; set; }
        public TransactionType TransactionType { get; set; } // Enum for TransactionType

        public Transaction() { }
        public Transaction(int transactionID, int boxID, int apparelID, int quantityChange, DateTime transactionTime, TransactionType transactionType)
        {
            TransactionID = transactionID;
            BoxID = boxID;
            ApparelID = apparelID;
            QuantityChange = quantityChange;
            TransactionTime = transactionTime;
            TransactionType = transactionType;
        }
    }
}
