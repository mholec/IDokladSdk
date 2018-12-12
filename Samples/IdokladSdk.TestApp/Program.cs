using System;
using System.Collections.Generic;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.Clients.Auth;

namespace IdokladSdk.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var authCredentials = new AuthorizationCodeAuth("client_id", "client_secret", "code", "http://localhost:3432");
            //var url = AuthorizationCodeAuth.GetClientAuthenticationUrl("client_id", "http://localhost:3432");

            // choose authorization flow
            var clientCred = new ClientCredentialAuth("client_id", "client_secret");

            // initialise context with configuration
            var apiContext = new ApiContext(clientCred)
            {
                AppName = "Application name"
            };

            // initialise api explorer
            var api = new ApiExplorer(apiContext);

            // get template for new contact
            var template = api.Contacts.Default();

            // cast to insert model
            var contact = (ContactCreate)template;

            // fill new contact
            contact.CompanyName = "New Company";

            // insert
            var addedContact = api.Contacts.Create(contact);

            // delete
            bool isDeleted = api.Contacts.Delete(addedContact.Id);

            // get all
            var allContacts = api.Contacts.Contacts(new ApiFilter().WithPaging(1, int.MaxValue));

            // prepare custom filter for querying
            var contactFilter = new ContactFilter();
            contactFilter.DateLastChange.IsEqualOrGreatherThan(new DateTime(2016, 1, 1));

            // query data using custom filter
            var contacts = api.Contacts.ContactsExpand(
                new ApiFilter(contactFilter, FilterType.And).AddOrderDesc("Id").WithPaging(1, 5));

            List<ValidationMessage> errors;
            bool isValid = ApiValidator.ValidateObject(contact, out errors);

            if (isValid)
            {
                var result = api.Contacts.Create(new ContactCreate());
            }
        }
    }
}
