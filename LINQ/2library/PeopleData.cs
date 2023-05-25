
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace _2library {
    public class PeopleData {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
        [JsonPropertyName("language")]
        public string Language { get; set; }
        [JsonPropertyName("university")]
        public string University { get; set; }
        [JsonPropertyName("date_of_birth")]
        public string DateOfBirth { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("company")]
        public string Company { get; set; }
        [JsonPropertyName("job_title")]
        public string JobTitle { get; set; }

    }
}