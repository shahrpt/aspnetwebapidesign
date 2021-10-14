using Fbg.Market.Models.Product;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Fbg.Market.Repository.Product
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        private readonly DapperContext _context;

        public ProductRepository(IConfiguration configuration, DapperContext context) : base(configuration)
        {
            _context = context;
        }

        public ProductRepository(IConfiguration configuration)
            : base(configuration)
        { }

        public async Task<List<Model.Product>> GetAllAsync()
        {
            var query = "SELECT * FROM Products";
            using (var connection = _context.CreateConnection())
            {
                var products = await connection.QueryAsync<Model.Product>(query);
                return products.ToList();
            }
           
        }

        public Task<Model.Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> CreateAsync(Model.Product entity)
        {
            var query = "INSERT INTO Products (Name, SKUCode, UPCCode) VALUES (@Name, @SkuCode, @UpcCode)" +
        "SELECT CAST(SCOPE_IDENTITY() as int)";
            var parameters = new DynamicParameters();
            parameters.Add("Name", entity.Description, DbType.String);
            parameters.Add("SkuCode", entity.Amount, DbType.String);
            parameters.Add("UpcCode", entity.Comment, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                var id = await connection.QuerySingleAsync<int>(query, parameters);
                return id;
            }
        }

        public async Task<int> UpdateAsync(int id, Model.Product entity)
        {
            var query = "UPDATE Products SET Name = @Name, Address = @Address, Country = @Country WHERE Id = @Id";
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            parameters.Add("Name", entity.Description, DbType.String);
            parameters.Add("Address", entity.Comment, DbType.String);
            parameters.Add("Country", entity.Date, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                return await connection.ExecuteAsync(query, parameters);
            }
            
        }

        public async Task<int> DeleteAsync(int id)
        {
            var query = "DELETE FROM Products WHERE Id = @Id";
            using (var connection = _context.CreateConnection())
            {
               return await connection.ExecuteAsync(query, new { id });
            }
        }

        public async Task<IEnumerable<Model.Product>> ListAsync(ProductsQuery input)
        {
            var query = "SELECT * FROM Products";
            using (var connection = _context.CreateConnection())
            {
                var products = await connection.QueryAsync<Model.Product>(query);
                return products;
            }
        }

        public async Task<Model.Product> AddAsync(Model.Product entity)
        {
            var query = "INSERT INTO Products (Name, SKUCode, UPCCode) VALUES (@Name, @SkuCode, @UpcCode)" +
         "SELECT CAST(SCOPE_IDENTITY() as int)";
            var parameters = new DynamicParameters();
            parameters.Add("Name", entity.Description, DbType.String);
            parameters.Add("SkuCode", entity.Amount, DbType.String);
            parameters.Add("UpcCode", entity.Comment, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                var id = await connection.QuerySingleAsync<int>(query, parameters);
                return new Model.Product() { Id=id };
            }
        }

        public Task<Model.Product> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
