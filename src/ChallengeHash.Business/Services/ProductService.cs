using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeHash.Business.Intefaces;
using ChallengeHash.Business.Models;

namespace ChallengeHash.Business.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository,
                              INotify notify) : base(notify)
        {
            _productRepository = productRepository;
        }

        private bool GetGift()
        {
            if (DateTime.Now.Date.ToString("dd/MM/yyyy").Equals("27/11/2022"))
                return true;

            return false;
        }

        public async Task Create(Product product)
        {
            await _productRepository.Create(product);
        }

        public async Task Update(Product product)
        {
            await _productRepository.Update(product);
        }

        public async Task Delete(int id)
        {
            await _productRepository.Remove(id);
        }

        public async Task<List<Product>> GetProducts(List<int> ids)
        {
            var products = new List<Product>();

            foreach(var item in ids.Distinct())
            {
                var product = await _productRepository.GetById(item);

                if (product != null)
                    products.Add(product);
            }

            if (GetGift())
                products.Add(await _productRepository.GetGift());

            return products;
        }

        public void Dispose()
        {
            _productRepository?.Dispose();
        }
    }
}