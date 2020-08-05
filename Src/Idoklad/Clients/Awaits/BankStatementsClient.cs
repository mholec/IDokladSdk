using System.Threading.Tasks;
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
        /// <summary>
        /// GET api/BankStatements/
        /// Method returns list of banks, that were changed.
        /// </summary>
        public Task<RowsResultWrapper<BankStatement>> StatementsAsync(int? statementId = null, ApiFilter filter = null)
        {
            string url = ResourceUrl;
            if (statementId.HasValue)
                url += "/" + statementId.Value;

            return GetAsync<RowsResultWrapper<BankStatement>>(url, filter);
        }


        /// <summary>
        /// GET api/Banks/{id}
        /// Method returns bank by Id.
        /// </summary>
        public Task<BankPairResult> PairAsync(BankPairStatement bankPairStatement)
        {
            return PostAsync<BankPairResult, BankPairStatement>(ResourceUrl + "/Pair", bankPairStatement);
        }
    }
}