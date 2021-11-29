using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ChallengeHash.Api.ViewModels;
using ChallengeHash.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeHash.Api.Controllers
{
    [Route("api/checkouts")]
    public class CheckoutController : MainController
    {
        private readonly INotify _notify;
        private readonly IProductRepository _productRepository;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public CheckoutController(INotify notify,
            IProductRepository productRepository,
            IProductService productService,
            IMapper mapper) : base(notify)
        {
            _notify = notify;
            _productRepository = productRepository;
            _productService = productService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<CheckoutViewModel>> Insert(List<ProductCheckoutViewModel> productCheckoutViewModel)
        {
            var products = _mapper.Map<List<ProductViewModel>>(await _productService.GetProducts(productCheckoutViewModel.Select(p => p.Id).ToList()));

            var productsCheck = new List<ProductViewModel>();

            foreach (var item in productCheckoutViewModel)
            {
                var product = products.Where(p => p.Id.Equals(item)).First();

                product.Quantity = item.Quantity;
                product.TotalAmount = product.Amount * product.Quantity;

                productsCheck.Add(product);
            }

            var checkout = new CheckoutViewModel(productsCheck);


            return CustomResponse(checkout);
        }

    }
}

