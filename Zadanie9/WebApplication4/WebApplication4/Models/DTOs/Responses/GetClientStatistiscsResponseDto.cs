using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System;

namespace WebApplication4.Models.DTOs.Responses
{
    public class GetClientStatistiscsResponseDto
    {
        public string LastName { get; set; }
        public string Counter { get; set; }
    }

    public class GetCountriesTripsResponseDto
    {
        public string Name { get; set; }
    }

    public class GetClientsTripsResponseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class GetTripsResponseDto
    {
        [JsonProperty(Order = 1)]
        public string Name { get; set; }

        [JsonProperty(Order = 2)]
        public string Description { get; set; }

        [JsonProperty(Order = 3)]
        public DateTime? DateFrom { get; set; }

        [JsonProperty(Order = 4)]
        public DateTime? DateTo { get; set; }

        [JsonProperty(Order = 5)]
        public int? MaxPeople { get; set; }

        [JsonProperty(Order = 6)]
        public IEnumerable<GetCountriesTripsResponseDto> Countries;

        [JsonProperty(Order = 7)]
        public IEnumerable<GetClientsTripsResponseDto> Clients;

    }
}
