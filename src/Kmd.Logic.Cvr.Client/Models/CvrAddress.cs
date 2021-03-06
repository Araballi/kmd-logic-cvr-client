// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Cvr.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CvrAddress
    {
        /// <summary>
        /// Initializes a new instance of the CvrAddress class.
        /// </summary>
        public CvrAddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CvrAddress class.
        /// </summary>
        public CvrAddress(string streetCode = default(string), string streetName = default(string), string houseNumber = default(string), string communityCode = default(string), string postCode = default(string), string postDistrict = default(string), string countryCode = default(string))
        {
            StreetCode = streetCode;
            StreetName = streetName;
            HouseNumber = houseNumber;
            CommunityCode = communityCode;
            PostCode = postCode;
            PostDistrict = postDistrict;
            CountryCode = countryCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "streetCode")]
        public string StreetCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "streetName")]
        public string StreetName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "houseNumber")]
        public string HouseNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "communityCode")]
        public string CommunityCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postCode")]
        public string PostCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postDistrict")]
        public string PostDistrict { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

    }
}
