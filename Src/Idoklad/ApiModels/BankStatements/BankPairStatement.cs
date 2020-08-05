using System;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels.BankStatements
{
    public class BankPairStatement : IApiModel
    {
        public string AccountNumber { get; set; }

        public decimal Amount { get; set; }

        public decimal Balance { get; set; }

        public string BankCode  { get; set; }
        public string ConstantSymbol { get; set; }

        public string CurrencyCode { get; set; }

        public DateTime DateOfTransaction { get; set; }

        public string IBan { get; set; }

        public string MessageForPartner { get; set; }

        [ValidEnumValue]
        public MovementTypeEnum MovementType { get; set; }

        public string PartnerAccountNumber { get; set; }

        public string PartnerBankCode { get; set; }

        public string PartnerIban { get; set; }

        public string SpecificSymbol { get; set; }

        public string VariableSymbol { get; set; }
    }
}