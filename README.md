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



# IDoklad SDK for iDoklad API v1

## Quick start

Example of use in the project **samples/ConsoleSampleApplication**

### Step 1: Authorize
At the beginning you have to sign in. Authentication is recommended at the beginning of each set of calls. IDoklad currently provides **token with unexpected life length**.

	var authClient = new OAuthClient("your@email.tld", "password");
	var apiContext = new ApiContext(authClient.GetSecureToken())
	{
	    AppName = "Application name",
	};

Of course you can skip authentication an create `ApiContext` directly using your token. This approach is on your own risk.

### Step 2: Play

Once you have `ApiContext` with valid token, you can create `ApiExplorer` and **start to make various calls to API**.


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
	var contacts = api.Contacts.Contacts(new Paging(int.MaxValue));

	// get many
	var contacts = api.Contacts.Contacts(new Paging(1, 20));

## Supported frameworks

We currently support
- .NET 4.5
- .NET 4.5.1
- .NET 4.5.2
- .NET 4.6

## NuGet
You can install **SDK for iDoklad API** using the [NuGet](https://www.nuget.org)

	PM> Install-Package IdokladSdk
