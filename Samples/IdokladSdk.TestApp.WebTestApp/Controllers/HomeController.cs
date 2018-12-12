using System.Web.Mvc;
using IdokladSdk;
using IdokladSdk.ApiFilters;
using IdokladSdk.Clients;
using IdokladSdk.Clients.Auth;

namespace WebSampleApplication.Controllers
{
    public class HomeController : Controller
    {
        private static Tokenizer _token;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Code(string code)
        {
            AuthorizationCodeAuth auth = new AuthorizationCodeAuth(Settings.ClientId, Settings.ClientSecret, code, Settings.Url);

            ApiContext api = new ApiContext(auth);
            
            _token = api.Token;

            return RedirectToAction("Data");
        }

        public ActionResult Data()
        {
            ApiContext api = new ApiContext(_token);

            if (_token.Issued < api.Token.Issued)
            {
                _token = api.Token;
            }

            IssuedInvoiceClient invoiceClient = new IssuedInvoiceClient(api);
            var filter = new IssuedInvoiceFilter();

            return View(invoiceClient.IssuedInvoices(new ApiFilter(filter).AddOrderDesc("DateOfIssue")).Data);
        }
    }
}