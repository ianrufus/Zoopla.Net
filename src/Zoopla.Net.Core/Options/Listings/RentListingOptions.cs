﻿using Zoopla.Net.Core.Options.Enums;

namespace Zoopla.Net.Core.Options.Listings
{
    public class RentListingOptions : ListingBaseOptions
    {
        public RentListingOptions()
        {
            IncludeRented = 0;
            UrlValues["listing_status"] = "rent";
        }

        /// <summary>
        /// Value is either 0 (false) or 1 (true)
        /// </summary>
        public int IncludeRented
        {
            set => UrlValues["include_rented"] = value.ToString();
        }
        public Furnished Furnished
        {
            set => UrlValues["furnished"] = value.ToString()?.ToLower();
        }
    }
}
