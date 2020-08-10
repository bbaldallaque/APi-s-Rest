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
            var GetAllProduct = _product.GetAllProduct();
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
        public IActionResult Create(CreateProductViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var mapperProductInModel = _mapper.Map<Product>(vm);
                _product.InsertProduct(mapperProductInModel);
                _product.Save();
                return RedirectToAction(nameof(Index));
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
        public IActionResult Edit(EditProductViewModel vm)
        {
            var mapperProductInModel = _mapper.Map<Product>(vm);
            _product.UpdateProduct(mapperProductInModel);
            _product.Save();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var product = _product.GetProductById(id);
            var mapperProduct = _mapper.Map<DeleteProductViewModel>(product);
            return View(mapperProduct);
        }

        [HttpPost]
        public IActionResult Delete(DeleteProductViewModel vm)
        {
            var mapperProductInModel = _mapper.Map<Product>(vm);
            _product.DeleteProrduct(mapperProductInModel);
            _product.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}