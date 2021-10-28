using Fbg.Market.Models.Product;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Fbg.Market.DbModel;
using System.Data.SqlClient;
using Fbg.Market.Application;

namespace Fbg.Market.Repository.Product
{
    public class ProductRepository : DapperContext, IProductRepository
    {
        private readonly string _connectionString;

        /*public ProductRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("FBGMarket_CS");
        }*/
        public async Task<List<DbModel.Model.Product>> GetAllAsync()
        {
            var query = "SELECT * FROM Products";
            using (var connection = CreateConnection())
            {
                var products = await connection.QueryAsync<DbModel.Model.Product>(query);
                return products.ToList();
            }
           
        }

        public Task<DbModel.Model.Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

       
        public async Task<DbModel.Model.Product> UpdateAsync(int id, DbModel.Model.Product entity)
        {
            var query = @"UPDATE [dbo].[Products]
   SET [BID] = @BID
      ,[SKUCode] = @SKUCode
      ,[UPCCode] = @UPCCode
      ,[PName] = @PName
      ,[PColor] = @PColor
      ,[PSize] = @PSize
      ,[PCategory] = @PCategory
      ,[PSubCategory] = @PSubCategory
      ,[NRFColorCodeID] = @NRFColorCodeID
      ,[SID] = @SID
      ,[PDescription] = @PDescription
      ,[PSpecs] = @PSpecs
      ,[PCoutryofOrigin] = @PCoutryofOrigin
      ,[PFOBCost] = @PFOBCost
      ,[PLandedCost] = @PLandedCost
      ,[PWholesalePrice] = @PWholesalePrice
      ,[PMSRPPrice] = @PMSRPPrice
      ,[PPicture] = @PPicture
      ,[ProductStatusId] = @ProductStatusId
      ,[VID] = @VID
      ,[ColorCategoryId] = @ColorCategoryId
      ,[ShopifyPicUrl] = @ShopifyPicUrl
      ,[VendorName] = @VendorName
 WHERE PID = @PID";
            var parameters = new DynamicParameters();
            parameters.Add("@BID", entity.BID, DbType.Int32);
            parameters.Add("@SKUCode", entity.SKUCode, DbType.String);
            parameters.Add("@UPCCode", entity.UPCCode, DbType.String);
            parameters.Add("@PName", entity.PName, DbType.String);
            parameters.Add("@PColor", entity.PColor, DbType.String);
            parameters.Add("@PSize", entity.PSize, DbType.String);
            parameters.Add("@PCategory", entity.PCategory, DbType.String);
            parameters.Add("@PSubCategory", entity.PSubCategory, DbType.String);
            parameters.Add("@NRFColorCodeID", entity.NRFColorCodeID, DbType.Int32);
            parameters.Add("@SID", entity.SID, DbType.Int32);
            parameters.Add("@PDescription", entity.PDescription, DbType.String);
            parameters.Add("@PSpecs", entity.PSpecs, DbType.String);
            parameters.Add("@PCoutryofOrigin", entity.PCoutryofOrigin, DbType.String);
            parameters.Add("@PFOBCost", entity.PFOBCost, DbType.Decimal);
            parameters.Add("@PLandedCost", entity.PLandedCost, DbType.Decimal);
            parameters.Add("@PWholesalePrice", entity.PWholesalePrice, DbType.Decimal);
            parameters.Add("@PMSRPPrice", entity.PMSRPPrice, DbType.Decimal);
            parameters.Add("@PPicture", entity.PPicture, DbType.String);
            parameters.Add("@ProductStatusId", entity.ProductStatusId, DbType.Int32);
            parameters.Add("@VID", entity.VID, DbType.Int32);
            parameters.Add("@ColorCategoryId", entity.ColorCategoryId, DbType.Int32);
            parameters.Add("@ShopifyPicUrl", entity.ShopifyPicUrl, DbType.String);
            parameters.Add("@VendorName", entity.VendorName, DbType.String);
            parameters.Add("@PID", entity.PID, DbType.Int32);
            using (var connection = CreateConnection())
            {
                var retVal = await connection.ExecuteAsync(query, parameters);
                if (retVal >= 0)
                {
                    return entity;
                }
            }
            return null;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var query = "DELETE FROM Products WHERE Id = @Id";
            using (var connection = CreateConnection())
            {
               return await connection.ExecuteAsync(query, new { id });
            }
        }

        public async Task<IEnumerable<DbModel.Model.Product>> ListAsync(ProductsQuery input)
        {
            var query = "SELECT * FROM Products";
            using (var connection = CreateConnection())
            {
                var products = await connection.QueryAsync<DbModel.Model.Product>(query);
                return products;
            }
        }

        public async Task<DbModel.Model.Product> AddAsync(DbModel.Model.Product entity)
        {
            var query = @"INSERT INTO [dbo].[Products]
           ([BID]
           ,[SKUCode]
           ,[UPCCode]
           ,[PName]
           ,[PColor]
           ,[PSize]
           ,[PCategory]
           ,[PSubCategory]
           ,[NRFColorCodeID]
           ,[SID]
           ,[PDescription]
           ,[PSpecs]
           ,[PCoutryofOrigin]
           ,[PDiscontinued]
           ,[PFOBCost]
           ,[PLandedCost]
           ,[PWholesalePrice]
           ,[PMSRPPrice]
           ,[PPicture]
           ,[ProductStatusId]
           ,[VID]
           ,[ColorCategoryId]
           ,[ShopifyPicUrl]
           ,[VendorName])
     VALUES
           (@BID
           ,@SKUCode
           ,@UPCCode
           ,@PName
           ,@PColor
           ,@PSize
           ,@PCategory
           ,@PSubCategory
           ,@NRFColorCodeID
           ,@SID
           ,@PDescription
           ,@PSpecs
           ,@PCoutryofOrigin
           ,@PFOBCost
           ,@PLandedCost
           ,@PWholesalePrice
           ,@PMSRPPrice
           ,@PPicture
           ,@ProductStatusId
           ,@VID
           ,@ColorCategoryId
           ,@ShopifyPicUrl
           ,@VendorName)";
            var parameters = new DynamicParameters();
            parameters.Add("@BID", entity.BID, DbType.Int32);
            parameters.Add("@SKUCode", entity.SKUCode, DbType.String);
            parameters.Add("@UPCCode", entity.UPCCode, DbType.String);
            parameters.Add("@PName", entity.PName, DbType.String);
            parameters.Add("@PColor", entity.PColor, DbType.String);
            parameters.Add("@PSize", entity.PSize, DbType.String);
            parameters.Add("@PCategory", entity.PCategory, DbType.String);
            parameters.Add("@PSubCategory", entity.PSubCategory, DbType.String);
            parameters.Add("@NRFColorCodeID", entity.NRFColorCodeID, DbType.Int32);
            parameters.Add("@SID", entity.SID, DbType.Int32);
            parameters.Add("@PDescription", entity.PDescription, DbType.String);
            parameters.Add("@PSpecs", entity.PSpecs, DbType.String);
            parameters.Add("@PCoutryofOrigin", entity.PCoutryofOrigin, DbType.String);
            parameters.Add("@PFOBCost", entity.PFOBCost, DbType.Decimal);
            parameters.Add("@PLandedCost", entity.PLandedCost, DbType.Decimal);
            parameters.Add("@PWholesalePrice", entity.PWholesalePrice, DbType.Decimal);
            parameters.Add("@PMSRPPrice", entity.PMSRPPrice, DbType.Decimal);
            parameters.Add("@PPicture", entity.PPicture, DbType.String);
            parameters.Add("@ProductStatusId", entity.ProductStatusId, DbType.Int32);
            parameters.Add("@VID", entity.VID, DbType.Int32);
            parameters.Add("@ColorCategoryId", entity.ColorCategoryId, DbType.Int32);
            parameters.Add("@ShopifyPicUrl", entity.ShopifyPicUrl, DbType.String);
            parameters.Add("@VendorName", entity.VendorName, DbType.String);

            using (var connection = CreateConnection())
            {
                var id = await connection.QuerySingleAsync<int>(query, parameters);
                return new DbModel.Model.Product() { PID=id };
            }
        }

        public async Task<DbModel.Model.Product> FindByIdAsync(int id)
        {
            var query = "SELECT * FROM Products";
            using (var connection = CreateConnection())
            {
                return await connection.QuerySingleAsync<DbModel.Model.Product>(query);
            }
        }
    }
}
