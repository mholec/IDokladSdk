using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels.BankStatements
{
    public class BankPairResult : IApiModel
    {
        public string Message { get; set; }

        public int PairedInvoiceId { get; set; }

        public bool WasPaired { get; set; }
        public BankStatement CreatedBankStatement { get; set; }
    }
}