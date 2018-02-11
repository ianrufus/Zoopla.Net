﻿using Newtonsoft.Json;

namespace Zoopla.Net.Core.Models.LocalInfoGraphs
{
    public class LocalInfoGraphResponse : ResponseModelBase
    {
        [JsonProperty("people_graph_url")]
        public string PeopleGraphUrl { get; set; }

        [JsonProperty("crime_graph_url")]
        public string CrimeGraphUrl { get; set; }

        [JsonProperty("council_tax_graph_url")]
        public string CouncilTaxGraphUrl { get; set; }

        [JsonProperty("education_graph_url")]
        public string EducationGraphUrl { get; set; }
    }
}
