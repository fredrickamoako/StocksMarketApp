﻿using Stocks.Core.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Core.Entities
{
    public class BuyOrder
    {
        [Key]
        public Guid BuyOrderID { get; set; }
        [Required]
        public string StockSymbol { get; set; } = string.Empty;
        [Required]
        public string StockName { get; set; } = string.Empty;

        public DateTime DateAndTimeOfOrder { get; set; }

        [Range(1, 10000, ErrorMessage = "Value should be {0} minimum and {1} maximum")]
        public uint Quantity { get; set; }

        [Range(1, 10000, ErrorMessage = "Value should be {0} minimum and {1} maximum")]
        public double Price { get; set; }

        public BuyOrderResponse ToBuyOrderResponse()
        {
            throw new NotImplementedException();
        }
    }
}
