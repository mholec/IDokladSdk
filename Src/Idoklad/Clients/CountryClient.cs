﻿using System;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Methods for countries. Primary used with contacts.
    /// </summary>
    public class CountryClient : BaseClient
    {
        public const string ResourceUrl = "/Countries";

        public CountryClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/Countries/GetChanges
        /// Method returns list of countries, that were changed.
        /// </summary>
        public RowsResultWrapper<Country> Changes(DateTime lastCheck, ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<Country>>(ResourceUrl + "/GetChanges" + "?lastCheck=" + lastCheck.ToString(ApiContextConfiguration.DateFormat), filter);
        }

        /// <summary>
        /// GET api/Countries
        /// Method returns list of countries.
        /// </summary>
        public RowsResultWrapper<Country> Countries(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<Country>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/Countries/{id}
        /// Method returns country by Id.
        /// </summary>
        public Country Country(int countryId)
        {
            return Get<Country>(ResourceUrl + "/" + countryId);
        }
    }
}