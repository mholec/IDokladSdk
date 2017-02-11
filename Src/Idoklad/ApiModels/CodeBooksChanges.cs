﻿using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels
{
    /// <summary>
    /// Indication of changes of code books.
    /// </summary>
    public class CodeBooksChanges : IApiModel
    {
        public int Id { get; set; }

        public bool Bank { get; set; }

        public bool ConstantSymbols { get; set; }

        public bool Country { get; set; }

        public bool Currencies { get; set; }

        public bool ExchangeRates { get; set; }

        public bool PaymentOptions { get; set; }

        public bool VatRates { get; set; }
    }
}