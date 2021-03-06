﻿using System;
using System.Threading.Tasks;
using System.Xml.Serialization;
using transaction_service.domain.Entities;

namespace transaction_service.services.Services.XmlFileParsers
{
    [XmlType("Transaction")]
    public class XmlTransactionDocument
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("TransactionDate")]
        public DateTime Date { get; set; }

        [XmlElement("PaymentDetails")]
        public PaymentDetailsDocument PaymentDetails { get; set; }

        [XmlElement("Status")]
        public XmlTransactionStatusDocument Status { get; set; }


        public Task<Transaction> MapToEntity()
        {
            return Task.Run(() => new Transaction
            {
                Id = Id,
                Amount = PaymentDetails.Amount,
                Currency = PaymentDetails.CurrencyCode,
                Date = Date,
                Status = (TransactionStatus)Status
            });
        }
    }

    public class PaymentDetailsDocument
    {
        [XmlElement("Amount")]
        public decimal Amount { get; set; }

        [XmlElement("CurrencyCode")]
        public string CurrencyCode { get; set; }
    }

    public enum XmlTransactionStatusDocument
    {
        Approved = 0,
        Rejected = 1,
        Done = 2
    }
}