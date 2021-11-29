using System.Threading.Tasks;
using ChallengeHash.Business.Intefaces;
using ChallengeHash.Business.Models;
using ChallengeHash.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ChallengeHash.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(MyDbContext context) : base(context) { }


        public async Task<Product> GetGift()
        {
            return await Db.Products
                .FirstOrDefaultAsync(p => p.IsGift);
        }
    }
}