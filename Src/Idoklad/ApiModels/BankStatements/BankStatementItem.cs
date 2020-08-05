using System;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels.BankStatements
{
    public class BankStatementItem
    {
        public bool ConstantSymbolId { get; set; }

        public int CurrencyId { get; set; }

        public DateTime DateOfTransaction { get; set; }

        public int ExchangeRate { get; set; }

        public int ExchangeRateAmount { get; set; }

        public int Id { get; set; }

        public bool IsPaired { get; set; }

        [ValidEnumValue]
        public MovementTypeEnum MovementType { get; set; }

        public decimal PayedAmount { get; set; }

        public decimal PayedAmountHc { get; set; }

        public string PartnerAccountNumber { get; set; }

        public string PartnerBancCode { get; set; }

        public string PartnerIban { get; set; }

        public string PartnerSwift { get; set; }

        public decimal PriceTotalWithVat { get; set; }

        [ValidEnumValue]
        public PriceTypeEnum PriceType { get; set; }

        public string SpecificSymbol { get; set; }

        public string Text { get; set; }

        public string VariableSymbol { get; set; }

        public decimal VatRate { get; set; }

        [ValidEnumValue]
        public VatRateTypeEnum VatRateType { get; set; }
    }
}