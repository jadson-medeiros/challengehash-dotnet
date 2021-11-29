namespace ChallengeHash.Business.Models
{
    public class Product : Entity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int Amount { get; set; }

        public bool IsGift { get; set; }
    }
}