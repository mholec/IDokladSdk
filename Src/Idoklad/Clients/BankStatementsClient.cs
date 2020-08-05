using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BankStatements;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Method for getting banks.
    /// </summary>
    public partial class BankStatementsClient : BaseClient
    {
        public const string ResourceUrl = "/BankStatements";

        public BankStatementsClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/BankStatements/
        /// Method returns list of banks, that were changed.
        /// </summary>
        public RowsResultWrapper<BankStatement> Statements(int? statementId = null, ApiFilter filter = null)
        {
            string url = ResourceUrl;
            if (statementId.HasValue)
                url += "/" + statementId.Value;

            return Get<RowsResultWrapper<BankStatement>>(url, filter);
        }


        /// <summary>
        /// GET api/Banks/{id}
        /// Method returns bank by Id.
        /// </summary>
        public BankPairResult Pair(BankPairStatement bankPairStatement)
        {
            return Post<BankPairResult, BankPairStatement>(ResourceUrl + "/Pair", bankPairStatement);
        }
    }
}