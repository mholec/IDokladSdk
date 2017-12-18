namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for recived invoice
    /// </summary>
    public class ReceivedInvoiceFilter
    {
        public FilterItem Id { get; set; } = new FilterItem("Id");
        public FilterItem CurrencyId { get; set; } = new FilterItem("CurrencyId");
        public CompareFilterItem DateLastChanged { get; set; } = new CompareFilterItem("DateLastChange");
        public CompareFilterItem DateOfIssue { get; set; } = new CompareFilterItem("DateOfIssue");
        public CompareFilterItem DateOfPayment { get; set; } = new CompareFilterItem("DateOfPayment");
        public CompareFilterItem DateOfMaturity { get; set; } = new CompareFilterItem("DateOfMaturity");
        public FilterItem Exported { get; set; } = new FilterItem("Exported");
        public ContainFilterItem Description { get; set; } = new ContainFilterItem("Description");
        public FilterItem NumericSequenceId { get; set; } = new FilterItem("NumericSequenceId");
        public ContainFilterItem DocumentNumber { get; set; } = new ContainFilterItem("DocumentNumber");
        public FilterItem IsPaid { get; set; } = new FilterItem("IsPaid");
        public FilterItem PaymentStatus { get; set; } = new FilterItem("PaymentStatus");
        public CompareFilterItem DateOfReceiving { get; set; } = new CompareFilterItem("DateOfReceiving");
        public FilterItem SupplierId { get; set; } = new FilterItem("SupplierId");
    }
}