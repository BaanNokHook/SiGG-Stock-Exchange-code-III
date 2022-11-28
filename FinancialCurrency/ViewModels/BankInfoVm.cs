﻿using FinancialCurrency.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialCurrency.API.ViewModels
{
    public class ReemVm
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public String Message { get; set; }
    }
}
