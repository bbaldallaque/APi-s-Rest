using Shoping.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shoping.Service.Infraestructure.Repository.Interfaces
{
    public interface IProduct
    {
        Task<List<Product>> GetAllProduct();
        void InsertProduct(Product product);
        void DeleteProrduct(Product product);
        void UpdateProduct(Product product);
        Task<Product> GetProductById(int? Id);
        void Save();
    }
}
