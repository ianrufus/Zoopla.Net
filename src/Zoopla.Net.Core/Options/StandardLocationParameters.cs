﻿using System.Text.RegularExpressions;
using Zoopla.Net.Core.Options.Enums;

namespace Zoopla.Net.Core.Options
{
    public class StandardLocationParameters : OptionsBase
    {
        public string Area
        {
            set => UrlValues["area"] = value?.ToLower();
        }
        public string Street
        {
            set => UrlValues["street"] = value?.ToLower();
        }
        public string Town
        {
            set => UrlValues["town"] = value?.ToLower();
        }
        public string PostCode
        {
            set => UrlValues["postcode"] = Regex.Replace(value, @"\s+", "");
        }
        public string County
        {
            set => UrlValues["county"] = value?.ToLower();
        }
        public string Country
        {
            set => UrlValues["country"] = value?.ToLower();
        }
        public OutputType OutputType
        {
            set => UrlValues["output_type"] = value.ToString()?.ToLower();
        }

        public AreaType AreaType
        {
            set => UrlValues["area_type"] = value.ToString()?.ToLower();
        }
    }
}
