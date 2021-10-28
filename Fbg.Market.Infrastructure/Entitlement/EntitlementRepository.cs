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
using Fbg.Market.DbModel.Model;
using Fbg.Market.Models.Entitlement;

namespace Fbg.Market.Repository.Product
{
    public class EntitlementRepository : DapperContext, IEntitlementRepository
    {
        private readonly string _connectionString;

       
        public async Task<List<AspNetUser>> GetAllAsync()
        {
            var query = "SELECT * FROM AspNetUser";
            using (var connection = CreateConnection())
            {
                var products = await connection.QueryAsync<AspNetUser>(query);
                return products.ToList();
            }
           
        }

        public Task<AspNetUser> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

       
        public async Task<AspNetUser> UpdateAsync(int id, AspNetUser entity)
        {
            var query = @"UPDATE [dbo].[AspNetUsers]
   SET [Email] = @Email
      ,[EmailConfirmed] = @EmailConfirmed
      ,[PasswordHash] = @PasswordHash
      ,[SecurityStamp] = @SecurityStamp
      ,[PhoneNumber] = @PhoneNumber
      ,[UserName] = @UserName
      ,[VID] = @VID
      ,[IsEnabled] = @IsEnabled
 WHERE ID = @ID";
            var parameters = new DynamicParameters();
            parameters.Add("@Id", entity.Id, DbType.String);
            parameters.Add("@Email", entity.Email, DbType.String);
            parameters.Add("@EmailConfirmed", entity.EmailConfirmed, DbType.Boolean);
            parameters.Add("@PasswordHash", entity.PasswordHash, DbType.String);
            parameters.Add("@SecurityStamp", entity.SecurityStamp, DbType.String);
            parameters.Add("@PhoneNumber", entity.PhoneNumber, DbType.String);
            parameters.Add("@UserName", entity.UserName, DbType.String);
            parameters.Add("@VID", entity.VID, DbType.Int32);
            parameters.Add("@IsEnabled", entity.IsEnabled, DbType.Boolean);

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
            var query = "DELETE FROM AspNetUser WHERE Id = @Id";
            using (var connection = CreateConnection())
            {
               return await connection.ExecuteAsync(query, new { id });
            }
        }

        public async Task<IEnumerable<AspNetUser>> ListAsync(UserQuery input)
        {
            var query = "SELECT * FROM AspNetUser";
            using (var connection = CreateConnection())
            {
                var products = await connection.QueryAsync<AspNetUser>(query);
                return products;
            }
        }

        public async Task<AspNetUser> AddAsync(AspNetUser entity)
        {
            var query = @"INSERT INTO [dbo].[AspNetUsers]
           ([Id]
           ,[Email]
           ,[EmailConfirmed]
           ,[PasswordHash]
           ,[SecurityStamp]
           ,[PhoneNumber]
           ,[UserName]
           ,[VID]
           ,[IsEnabled])
     VALUES
           (@Id
           ,@Email
           ,@EmailConfirmed
           ,@PasswordHash
           ,@SecurityStamp
           ,@PhoneNumber
           ,@UserName
           ,@VID
           ,@IsEnabled)";
            var parameters = new DynamicParameters();
            parameters.Add("@Id", entity.Id, DbType.String);
            parameters.Add("@Email", entity.Email, DbType.String);
            parameters.Add("@EmailConfirmed", entity.EmailConfirmed, DbType.Boolean);
            parameters.Add("@PasswordHash", entity.PasswordHash, DbType.String);
            parameters.Add("@SecurityStamp", entity.SecurityStamp, DbType.String);
            parameters.Add("@PhoneNumber", entity.PhoneNumber, DbType.String);
            parameters.Add("@UserName", entity.UserName, DbType.String);
            parameters.Add("@VID", entity.VID, DbType.Int32);
            parameters.Add("@IsEnabled", entity.IsEnabled, DbType.Boolean);

            using (var connection = CreateConnection())
            {
                var id = await connection.QuerySingleAsync<int>(query, parameters);
                return entity;
            }
        }

        public async Task<AspNetUser> FindByIdAsync(int id)
        {
            var query = "SELECT * FROM AspNetUser WHERE ID = @ID";
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, DbType.String);
            using (var connection = CreateConnection())
            {
                return await connection.QuerySingleAsync<AspNetUser>(query);
            }
        }
    }
}
