using FKDesignBusiness.Abstract;
using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Concrete
{
    public class ProductServices : IProductServices
    {
        private IUnitOfWork _unitOfWork;
        public ProductServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Product> CreateProduct(Product product)
        {
            await _unitOfWork.Products.AddAsync(product);
            return product;
        }

        public async Task DeleteProduct(Product product)
        {
            _unitOfWork.Products.Remove(product);
            await _unitOfWork.CommitAsync();
        }

        public async  Task<IEnumerable<Product>> GetAllProducts()
        {

            return await _unitOfWork.Products.GetAllAsync();

        }

        public async Task<Product> GetProductById(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }

        public async Task UpdateProduct(Product productToBeUpdate, Product product)
        {
            productToBeUpdate.ProductName = product.ProductName;
            await _unitOfWork.CommitAsync();
        }
    }
}
