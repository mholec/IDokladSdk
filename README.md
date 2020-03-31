<a href="https://www.nuget.org/packages/IdokladSdk"><img src="https://img.shields.io/nuget/dt/IdokladSdk" alt=""></a>

# [Deprecated] IDoklad SDK for C#
<div>
This repository is deprecated. <b><a href="https://github.com/Solitea/IdokladSdk">Check new iDoklad SDK repository</a> created by Solitea team.</b> It reflects the newest version of iDoklad API v3.0.
</div>

## Choose the right version

| API Version | API Status  | SDK Status  | SDK Source                                       | NuGet Version |
|-------------|-------------|-------------|--------------------------------------------------|---------------|
| iDoklad v3  | preview     | preview     | https://github.com/Solitea/IdokladSdk            | v3.x.x        |
| iDoklad v2  | maintenance | maintenance | https://github.com/mholec/IDokladSdk             | v2.x.x        |
| iDoklad v1  | maintenance | end of life | https://github.com/mholec/IDokladSdk/tree/SDK_V1 | v1.x.x        |



# IDoklad SDK for iDoklad API v2

**This SDK version works directly with IDoklad API service. Below is described communication with the IDoklad API v2**

Legacy version of SDK 1.0 is available in special branch: **[SDK_V1](https://github.com/mholec/idoklad-sdk-csharp/tree/SDK_V1)**. We recommend to use this version of SDK. This version fully supports newest version of iDoklad API.

## Quick start (examples)

- Basic use with client credential flow: **samples/ConsoleSampleApplication**
- Basic use with authorization code flow **samples/WebSampleApplication**

### Step 1: Authorize (client_credential flow)
At the beginning you have to sign in. Authentication is recommended at the beginning of each set of calls. 
You need to have your ClientId and ClientSecret. You can find this credentials in **[IDoklad settings page](https://app.idoklad.cz/Setting/LogonUser)**.
 
	var credentials = new ClientCredentialAuth("client_id", "client_secret");

    var apiContext = new ApiContext(clientCred)
    {
        AppName = "Application name",
        Configuration = {DateFormat = "yyyy-MM-dd HH:mm"}
    };

Authentication using the legacy API 1.0 is not available anymore.

### Step 2: Play

Once you have `ApiContext`, you can create `ApiExplorer` and **start to make various calls to API**.


For example, here is the entire flow of work with contacts.

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

	// get many
	var contacts = api.Contacts.Contacts(new Paging(1, 20));

	// get many with filter
    var contactFilter = new ContactFilter();
    contactFilter.DateLastChange.IsEqualOrGreatherThan(new DateTime(2016,1,1));

    var contacts = api.Contacts.ContactsExpand(
        new ApiFilter(contactFilter, FilterType.And).AddOrderDesc("Id").WithPaging(1, 5));

## Supported frameworks

From version 2.5.0 the SDK targets NET Standard 2.0. This version of standard is implemented by following frameworks:

- .NET Core 2.0+
- .NET Framework 4.6.1+
- Mono 5.4+
- Xamarin.iOS 10.14+
- Xamarin.Mac 3.8+
- Xamarin.Android 8.0+
- UWP 10.0.16299+
- Windows / Windows Phone 8.1+
- WP Silverlight 8.0+
- Unity 2018.1+

Other (older) frameworks are supported in Nuget version < 2.5.0)

## NuGet
You can install **SDK for iDoklad API** using the [NuGet](https://www.nuget.org/packages/IdokladSdk)

	PM> Install-Package IdokladSdk
