﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.Models
{
    public class TransactionLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }



        public TransactionLine()
        {

        }

        // Relations

        public int TransactioId { get; set; }
        public Transaction Transaction { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }


    }
}
