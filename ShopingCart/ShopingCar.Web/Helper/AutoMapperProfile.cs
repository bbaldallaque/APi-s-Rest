using AutoMapper;
using Shoping.Model.Dto;
using Shoping.Model.Entities;
using Shoping.Model.ViewModel.Product;

namespace ShopingCar.Web.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Product, EditProductViewModel>().ReverseMap();
            CreateMap<Product, CreateProductViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Product, DetailsViewModels>();
            CreateMap<Product, DeleteProductViewModel>().ReverseMap();
        }
    }
}
