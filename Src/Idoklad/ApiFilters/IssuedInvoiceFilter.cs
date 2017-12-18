namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for issued invoice
    /// </summary>
    public class IssuedInvoiceFilter : FilterableObjectBase
    {
        public FilterItem Id { get; set; } = new FilterItem("Id");
        public FilterItem ConstantSymbolId { get; set; } = new FilterItem("ConstantSymbolId");
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
        public FilterItem PurchaserId { get; set; } = new FilterItem("PurchaserId");
    }
}
