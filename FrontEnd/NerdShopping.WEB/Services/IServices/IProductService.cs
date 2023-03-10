using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NerdShopping.WEB.Models;

namespace NerdShopping.WEB.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts();
        Task<ProductModel> FindProductById(long id);
        Task<ProductModel> CreateProduct(ProductModel model);
        Task<ProductModel> UpdateProduct(ProductModel model);
        Task<bool> DeleteProductById(long id);
    }
}