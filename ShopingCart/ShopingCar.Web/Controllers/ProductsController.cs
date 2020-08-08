using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shoping.Model.Dto;
using Shoping.Model.Entities;
using Shoping.Model.ViewModel;
using Shoping.Model.ViewModel.Product;
using Shoping.Service.Infraestructure.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopingCar.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProduct _product;
        private readonly IMapper _mapper;

        public ProductsController(IProduct product, 
            IMapper mapper)
        {
            _product = product;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var GetAllProduct =  _product.GetAllProduct();
            var mapperProduct = _mapper.Map<List<ProductDto>>(GetAllProduct);

            return View(mapperProduct);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            var product = _product.GetProductById(id);
            var mapperProduct = _mapper.Map<ProductDto>(product);
            return View(mapperProduct);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
               
            }
            return View();
        }

        public IActionResult Edit(int id)
        {

            var product = _product.GetProductById(id);
            var mapperProduct = _mapper.Map<EditProductViewModel>(product);
            return View(mapperProduct);
        }

        [HttpPost]
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            var product = _product.GetProductById(id);
            var mapperProduct = _mapper.Map<DeleteProductViewModel>(product);
            return View(mapperProduct);
        }

    }
}
