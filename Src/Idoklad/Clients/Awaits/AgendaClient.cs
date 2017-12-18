using System.Collections.Generic;
using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Methods for manipulating with Agenda resources.
    /// </summary>
    public partial class AgendaClient : BaseClient
    {

        /// <summary>
        /// GET api/Agendas/GetAgendaSummary
        /// Summary of the user documents for agenda.
        /// </summary>
        public async Task<AgendaSummary> AgendaSummaryAsync()
        {
            return await GetAsync<AgendaSummary>(ResourceUrl + "/GetAgendaSummary");
        }

        /// <summary>
        /// GET api/Agendas/GetAgendaContact
        /// Contact information for agenda.
        /// </summary>
        public async Task<Contact> AgendaContactAsync()
        {
            return await GetAsync<Contact>(ResourceUrl + "/GetAgendaContact");
        }

        /// <summary>
        /// GET api/Agendas/GetAgendaContactExpand
        /// Contact information for agenda. Expanded edition.
        /// </summary>
        public async Task<ContactExpand> AgendaContactExpandAsync()
        {
            return await GetAsync<ContactExpand>(ResourceUrl + "/GetAgendaContactExpand");
        }

        /// <summary>
        /// GET api/Agendas/GetAgendaBankAccounts
        /// List of bank accounts for agenda.
        /// </summary>
        public async Task<List<BankAccount>> AgendaContactBankAccountsAsync()
        {
            return await GetAsync<List<BankAccount>>(ResourceUrl + "/GetAgendaBankAccounts");
        }

        /// <summary>
        /// GET api/Agendas/GetTopPartners
        /// Method calculates best partners by issued invoices sum.
        /// </summary>
        public async Task<List<SummaryTopPartner>> TopPartnersAsync()
        {
            return await GetAsync<List<SummaryTopPartner>>(ResourceUrl + "/GetTopPartners");
        }

        /// <summary>
        /// GET api/Agendas
        /// List of agendas.
        /// </summary>
        public async Task<RowsResultWrapper<Agenda>> AgendasAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<Agenda>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/Agendas/{id}
        /// Detail of the agenda by Id.
        /// </summary>
        public async Task<Agenda> AgendaAsync(int agendaId)
        {
            return await GetAsync<Agenda>(ResourceUrl + "/" + agendaId);
        }

        /// <summary>
        /// GET api/Agendas/Current
        /// Detail of the currently authorized agenda.
        /// </summary>
        public async Task<Agenda> CurrentAsync()
        {
            return await GetAsync<Agenda>(ResourceUrl + "/Current");
        }
    }
}
