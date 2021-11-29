using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ChallengeHash.Api.ViewModels
{
    public class CheckoutViewModel
    {
        [JsonPropertyName("total_amount")]
        public int TotalAmount { get; set; }

        [JsonPropertyName("total_amount_with_discount")]
        public int TotalAmountWithDiscount { get; set; }

        [JsonPropertyName("total_discount")]
        public int TotalDiscount { get; set; }

        [JsonPropertyName("products")]
        public List<ProductViewModel> Products { get; set; }

        public CheckoutViewModel()
        {

        }

        public CheckoutViewModel(List<ProductViewModel> products)
        {
            var total = 0;

            foreach(var item in products)
            {
                total += item.Amount;
            }

            this.TotalAmount = total;

            this.Products = products;
        }
    }
}