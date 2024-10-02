﻿using alexbelokopytov3_mvc.DAL.Models;
using Npgsql;
using Dapper;

namespace alexbelokopytov3_mvc.DAL
{
    public class AuthDAL : IAuthDAL
    {
        public async Task<UserModel> GetUser(string email)
        {
            using (var connection = new NpgsqlConnection(DbHelper.ConnString))
            {
                connection.Open();

                return await connection.QueryFirstOrDefaultAsync<UserModel>(@"
                    select UserId, Email, Password, Salt, Status
                    from AppUser
                    where Email = @email", new { email = email }) ?? new UserModel();
            }
        }

        public async Task<UserModel> GetUser(int id)
        {
            using (var connection = new NpgsqlConnection(DbHelper.ConnString))
            {
                connection.Open();

                return await connection.QueryFirstOrDefaultAsync<UserModel>(@"
                    select UserId, Email, Password, Salt, Status
                    from AppUser
                    where UserId = @id", new { id = id }) ?? new UserModel();
            }
        }

        public async Task<int> CreateUser(UserModel model)
        {
            using (var connection = new NpgsqlConnection(DbHelper.ConnString))
            {
                connection.Open();
                string sql = @"insert into AppUser(Email, Password, Salt, Status)
                    values(@Email, @Password, @Salt, @Status)";
                return await connection.ExecuteAsync(sql, model);
            }
        }

    }
}
