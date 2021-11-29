using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ChallengeHash.Api.ViewModels
{
    public class ProductCheckoutViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }
}