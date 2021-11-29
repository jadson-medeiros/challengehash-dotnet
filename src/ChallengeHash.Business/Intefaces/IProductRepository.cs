using System.Threading.Tasks;
using ChallengeHash.Business.Models;

namespace ChallengeHash.Business.Intefaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetGift();
    }
}