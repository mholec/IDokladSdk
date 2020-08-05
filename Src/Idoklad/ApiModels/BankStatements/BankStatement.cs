using System;
using System.Collections.Generic;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels.BankStatements
{
    public class BankStatement : IApiModel
    {
        public int BankAccountId { get; set; }

        public decimal CurrentBalance { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateLastChange { get; set; }

        public string DocumentNumber { get; set; }

        public int DocumentSerialNumber { get; set; }

        public int Id { get; set; }

        public List<BankStatementItem> Items { get; set; }

        public int NumericSequenceId { get; set; }
        public DateTime PeriodDateFrom { get; set; }
        public DateTime PeriodDateTo { get; set; }
    }
}