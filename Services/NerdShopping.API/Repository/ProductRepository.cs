using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NerdShopping.API.Data.ValueObjects;
using NerdShopping.API.Models;
using NerdShopping.API.Models.Context;

namespace NerdShopping.API.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly SQLContext _sql;
        private IMapper _mapper;
        public ProductRepository(SQLContext sql, IMapper mapper)
        {
            _sql = sql;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List<Product> products = await _sql.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(long id)
        {
            Product product = await _sql.Products
                                        .Where(p => p.Id == id)
                                        .FirstOrDefaultAsync();
            return _mapper.Map<ProductVO>(product);
        }

        public async Task<ProductVO> Create(ProductVO vo)
        {
            Product product = _mapper.Map<Product>(vo);
            _sql.Products.Add(product);
            await _sql.SaveChangesAsync();
            return _mapper.Map<ProductVO>(product);
        }

        public async Task<ProductVO> Update(ProductVO vo)
        {
            Product product = _mapper.Map<Product>(vo);
            _sql.Products.Update(product);
            await _sql.SaveChangesAsync();
            return _mapper.Map<ProductVO>(product);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Product product = await _sql.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (product is null) return false;
                _sql.Products.Remove(product);
                await _sql.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}