using FluentValidation;

namespace ChallengeHash.Business.Models.Validations
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
        }
    }
}