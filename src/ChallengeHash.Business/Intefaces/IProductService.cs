using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ChallengeHash.Business.Models;

namespace ChallengeHash.Business.Intefaces
{
    public interface IProductService : IDisposable
    {
        Task Create(Product product);
        Task Update(Product product);
        Task Delete(int id);
        Task<List<Product>> GetProducts(List<int> ids);
    }
}