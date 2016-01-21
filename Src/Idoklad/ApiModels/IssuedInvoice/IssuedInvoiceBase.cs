﻿using System;
using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels.IssuedInvoice
{
    public class IssuedInvoiceBase : ApiModel
    {
        /// <summary>
        /// Základ daně v základní sazbě v cizí měně
        /// </summary>
        /// <summary xml:lang="en">
        /// Tax base - basic rate
        /// </summary>
        public decimal BaseTaxBasicRate { get; set; }

        /// <summary>
        /// Základ daně v základní sazbě v domácí měně
        /// </summary>
        /// <summary xml:lang="en">
        /// Tax base - basic rate in home currency
        /// </summary>
        public decimal BaseTaxBasicRateHc { get; set; }

        /// <summary>
        /// Základ daně ve snížené sazbě 1 v cizí měně
        /// </summary>
        /// <summary xml:lang="en">
        /// Tax base - Reduce rate 1
        /// </summary>
        public decimal BaseTaxReducedRate1 { get; set; }

        /// <summary>
        /// Základ daně ve snížené sazbě 1 v domácí měně
        /// </summary>
        /// <summary xml:lang="en">
        /// Tax base - Reduce rate 1 in home currency
        /// </summary>
        public decimal BaseTaxReducedRate1Hc { get; set; }

        /// <summary>
        /// Základ daně ve snížené sazbě 2 v cizí měně
        /// </summary>
        /// <summary xml:lang="en">
        /// Tax base - Reduce rate 2
        /// </summary>
        public decimal BaseTaxReducedRate2 { get; set; }

        /// <summary>
        /// Základ daně ve snížené sazbě 1 v domácí měně
        /// </summary>
        /// <summary xml:lang="en">
        /// Tax base - Reduce rate 2 in home currency
        /// </summary>
        public decimal BaseTaxReducedRate2Hc { get; set; }

        /// <summary>
        /// Základ daně v nulové sazbě cizí měně
        /// </summary>
        /// <summary xml:lang="en">
        /// Tax base - Zero rate
        /// </summary>
        public decimal BaseTaxZeroRate { get; set; }

        /// <summary>
        /// Základ daně v nulové sazbě v domácí měně
        /// </summary>
        /// <summary xml:lang="en">
        /// Tax base - Zero rate in home currency
        /// </summary>
        public decimal BaseTaxZeroRateHc { get; set; }

        /// <summary>
        /// Id konstantního symbolu
        /// </summary>
        /// <summary xml:lang="en">
        /// Constant symbol Id
        /// </summary>
        public int ConstantSymbolId { get; set; }

        /// <summary>
        /// Id měny
        /// </summary>
        /// <summary xml:lang="en">
        /// Currency Id
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Datum poslední změny dokladu
        /// </summary>
        /// <summary xml:lang="en">
        /// Date last change
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Datum účetního připadu
        /// </summary>
        /// <summary xml:lang="en">
        /// Date of accounting event
        /// </summary>
        public DateTime DateOfAccountingEvent { get; set; }

        /// <summary>
        /// Datum vystavení dokladu
        /// </summary>
        /// <summary xml:lang="en">
        /// Date of issue
        /// </summary>
        public DateTime DateOfIssue { get; set; }

        /// <summary>
        /// Datum poslední upomínky
        /// </summary>
        /// <summary xml:lang="en">
        /// Date of last reminder
        /// </summary>
        public DateTime DateOfLastReminder { get; set; }

        /// <summary>
        /// Datum splatnosti
        /// </summary>
        /// <summary xml:lang="en">
        /// Date of maturity
        /// </summary>
        public DateTime DateOfMaturity { get; set; }

        /// <summary>
        /// Datum úhrady
        /// </summary>
        /// <summary xml:lang="en">
        /// Date of payment
        /// </summary>
        public DateTime DateOfPayment { get; set; }

        /// <summary>
        /// Datum uskutečnění zdanitelného plnění
        /// </summary>
        /// <summary xml:lang="en">
        /// Date of taxing
        /// </summary>
        public DateTime DateOfTaxing { get; set; }

        /// <summary>
        /// Popis dokladu
        /// </summary>
        /// <summary xml:lang="en">
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Číslo dokumentu
        /// </summary>
        /// <summary xml:lang="en">
        /// DocumentNumber
        /// </summary>
        [StringLength(10)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Pořadové číslo dokumentu
        /// </summary>
        /// <summary xml:lang="en">
        /// Document Serial Number
        /// </summary>
        public int DocumentSerialNumber { get; set; }

        /// <summary>
        /// Kurz měny
        /// </summary>
        /// <summary xml:lang="en">
        /// Exchange rate
        /// </summary>
        public decimal ExchangeRate { get; set; }

        /// <summary>
        /// Množství měny pro kurz
        /// </summary>
        /// <summary xml:lang="en">
        /// Exchange rate amount
        /// </summary>
        public decimal ExchangeRateAmount { get; set; }

        /// <summary>
        /// Příznak exportovaného dokumentu (Doporučuje se používat pouze jeden externí účetní software.)
        /// </summary>
        /// <summary xml:lang="en">
        /// Export to another accounting software indication. (It is recommended to use only one external accounting software
        /// beside iDoklad.)
        /// </summary>
        public ExportedStateEnum Exported { get; set; }

        /// <summary>
        /// Příznak Odesláno účetní
        /// </summary>
        /// <summary xml:lang="en">
        /// Indicate sending to accountant
        /// </summary>
        public bool IsSentToAccountant { get; set; }

        /// <summary>
        /// Příznak Odesláno odběrateli
        /// </summary>
        /// <summary xml:lang="en">
        /// Indicate sending to purchaser
        /// </summary>
        public bool IsSentToPurchaser { get; set; }

        /// <summary>
        /// Text před položkami
        /// </summary>
        /// <summary xml:lang="en">
        /// Items text prefix
        /// </summary>
        public string ItemsTextPrefix { get; set; }

        /// <summary>
        /// Text za položkami
        /// </summary>
        /// <summary xml:lang="en">
        /// Items text suffix
        /// </summary>
        public string ItemsTextSuffix { get; set; }

        /// <summary>
        /// Id jazyka tiskové sestavy
        /// </summary>
        /// <summary xml:lang="en">
        /// Report language Id
        /// </summary>
        public int LanguageId { get; set; }

        /// <summary>
        /// Splatnost dokumentu ve dnech
        /// </summary>
        /// <summary xml:lang="en">
        /// Maturity in days
        /// </summary>
        public short Maturity { get; set; }

        /// <summary>
        /// Id kontaktních údajů dodavatele
        /// </summary>
        /// <summary xml:lang="en">
        /// My company document address Id
        /// </summary>
        public int MyCompanyDocumentAdrressId { get; set; }

        /// <summary>
        /// Poznámka k dokumentu
        /// </summary>
        /// <summary xml:lang="en">
        /// Note
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Číslo objednávky
        /// </summary>
        /// <summary xml:lang="en">
        /// Order number
        /// </summary>
        [StringLength(20)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Id způsobu úhrady
        /// </summary>
        public int PaymentOptionId { get; set; }

        /// <summary>
        /// Stav zaplacení
        /// </summary>
        public PaymentStatusEnum PaymentStatus { get; set; }

        /// <summary>
        /// Id kontaktních údajů odběratele
        /// </summary>
        public int PurchaserDocumentAddressId { get; set; }

        /// <summary>
        /// Id odběratele
        /// </summary>
        public int PurchaserId { get; set; }

        /// <summary>
        /// Počet odesláných upomínek
        /// </summary>
        public int RemindersCount { get; set; }

        /// <summary>
        /// Barva tiskové sestavy
        /// </summary>
        /// <summary xml:lang="en">
        /// Report color in html color format
        /// </summary>
        public string ReportColorValue { get; set; }

        /// <summary>
        /// Id typu tiskové sestavy
        /// </summary>
        public int ReportId { get; set; }

        /// <summary>
        /// Zaokrouhlovací částka
        /// </summary>
        public decimal RoundingDifference { get; set; }

        /// <summary>
        /// Daň v základní sazbě v cizí měně
        /// </summary>
        public decimal TaxBasicRate { get; set; }

        /// <summary>
        /// Daň v základní sazbě v domácí měně
        /// </summary>
        public decimal TaxBasicRateHc { get; set; }

        /// <summary>
        /// Daň ve snížené sazbě 1 v cizí měně
        /// </summary>
        public decimal TaxReducedRate1 { get; set; }

        /// <summary>
        /// Daň ve snížené sazbě 1 v domácí měně
        /// </summary>
        public decimal TaxReducedRate1Hc { get; set; }

        /// <summary>
        /// Daň ve snížené sazbě 2 v cizí měně
        /// </summary>
        public decimal TaxReducedRate2 { get; set; }

        /// <summary>
        /// Daň ve snížené sazbě 2 v domácí měně
        /// </summary>
        public decimal TaxReducedRate2Hc { get; set; }

        /// <summary>
        /// Celková částka v základní sazbě v cizí měně
        /// </summary>
        public decimal TotalBasicRate { get; set; }

        /// <summary>
        /// Celková částka v základní sazbě v domácí měně
        /// </summary>
        public decimal TotalBasicRateHc { get; set; }

        /// <summary>
        /// Celková částka ve snížené sazbě 1 v cizí měně
        /// </summary>
        public decimal TotalReducedRate1 { get; set; }

        /// <summary>
        /// Celková částka ve snížené sazbě 1 v domácí měně
        /// </summary>
        public decimal TotalReducedRate1Hc { get; set; }

        /// <summary>
        /// Celková částka ve snížené sazbě 2 v cizí měně
        /// </summary>
        public decimal TotalReducedRate2 { get; set; }

        /// <summary>
        /// Celková částka ve snížené sazbě 2 v domácí měně
        /// </summary>
        public decimal TotalReducedRate2Hc { get; set; }

        /// <summary>
        /// Celková daň v cizí měně
        /// </summary>
        public decimal TotalVat { get; set; }

        /// <summary>
        /// Celková daň v domácí měně
        /// </summary>
        public decimal TotalVatHc { get; set; }

        /// <summary>
        /// Celková částka s daní v cizí měně
        /// </summary>
        public decimal TotalWithVat { get; set; }

        /// <summary>
        /// Celková částka s daní v domácí měně
        /// </summary>
        public decimal TotalWithVatHc { get; set; }

        /// <summary>
        /// Celková částka bez daně v cizí měně
        /// </summary>
        public decimal TotalWithoutVat { get; set; }

        /// <summary>
        /// Celková částka bez daně v domácí měně
        /// </summary>
        public decimal TotalWithoutVatHc { get; set; }

        /// <summary>
        /// Sleva v procentech
        /// </summary>
        /// <summary xml:lang="en">
        /// Discount for invoice
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Variabilní symbol
        /// </summary>
        [StringLength(10)]
        public string VariableSymbol { get; set; }

        /// <summary>
        /// Základní sazba daně
        /// </summary>
        public decimal VatRateBasic { get; set; }

        /// <summary>
        /// Snížena sazba daně 1
        /// </summary>
        public decimal VatRateReduced1 { get; set; }

        /// <summary>
        /// Snížena sazba daně 2
        /// </summary>
        public decimal VatRateReduced2 { get; set; }
    }
}