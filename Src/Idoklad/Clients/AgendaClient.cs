using System.Collections.Generic;
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
        public const string ResourceUrl = "/Agendas";

        public AgendaClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/Agendas/GetAgendaSummary
        /// Summary of the user documents for agenda.
        /// </summary>
        public AgendaSummary AgendaSummary()
        {
            return Get<AgendaSummary>(ResourceUrl + "/GetAgendaSummary");
        }

        /// <summary>
        /// GET api/Agendas/GetAgendaContact
        /// Contact information for agenda.
        /// </summary>
        public Contact AgendaContact()
        {
            return Get<Contact>(ResourceUrl + "/GetAgendaContact");
        }

        /// <summary>
        /// GET api/Agendas/GetAgendaContactExpand
        /// Contact information for agenda. Expanded edition.
        /// </summary>
        public ContactExpand AgendaContactExpand()
        {
            return Get<ContactExpand>(ResourceUrl + "/GetAgendaContactExpand");
        }

        /// <summary>
        /// GET api/Agendas/GetAgendaBankAccounts
        /// List of bank accounts for agenda.
        /// </summary>
        public List<BankAccount> AgendaContactBankAccounts()
        {
            return Get<List<BankAccount>>(ResourceUrl + "/GetAgendaBankAccounts");
        }

        /// <summary>
        /// GET api/Agendas/GetTopPartners
        /// Method calculates best partners by issued invoices sum.
        /// </summary>
        public List<SummaryTopPartner> TopPartners()
        {
            return Get<List<SummaryTopPartner>>(ResourceUrl + "/GetTopPartners");
        }

        /// <summary>
        /// GET api/Agendas
        /// List of agendas.
        /// </summary>
        public RowsResultWrapper<Agenda> Agendas(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<Agenda>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/Agendas/{id}
        /// Detail of the agenda by Id.
        /// </summary>
        public Agenda Agenda(int agendaId)
        {
            return Get<Agenda>(ResourceUrl + "/" + agendaId);
        }

        /// <summary>
        /// GET api/Agendas/Current
        /// Detail of the currently authorized agenda.
        /// </summary>
        public Agenda Current()
        {
            return Get<Agenda>(ResourceUrl + "/Current");
        }
    }
}
