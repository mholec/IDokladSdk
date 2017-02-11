﻿using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels
{
    /// <summary>
    /// Issued invoice for creation of new invoice
    /// </summary>
    public class IssuedInvoiceItemWrite 
    {
        /// <summary>
        /// Množství položky
        /// </summary>
        [Range(0.0, double.MaxValue)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Název položky
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(200)]
        public string Name { get; set; }

        /// <summary>
        /// Typ ceny položky
        /// </summary>
        [ValidEnumValue]
        public PriceTypeEnum? PriceType { get; set; }

        /// <summary>
        /// Měrná jednotka
        /// </summary>
        [StringLength(20)]
        public string Unit { get; set; }

        /// <summary>
        /// Cena za jednu jednotku
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Typ DPH položky
        /// </summary>
        [ValidEnumValue]
        public VatRateTypeEnum? VatRateType { get; set; }
    }
}