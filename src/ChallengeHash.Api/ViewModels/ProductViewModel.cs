using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ChallengeHash.Api.ViewModels
{
    public class ProductViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("unit_amount")]
        public int Amount { get; set; }

        [JsonPropertyName("total_amount")]
        public int TotalAmount { get; set; }

        [JsonPropertyName("discount")]
        public int Discount { get; set; }

        [JsonPropertyName("is_gift")]
        public bool IsGift { get; set; }
    }
}