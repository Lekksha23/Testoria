﻿using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;
using Testoria.Data.Configuration;

namespace Testoria.Data
{
    public class BaseRepository : IBaseRepository
    {
        private string _connectionString { get; set; }

        public BaseRepository(IOptions<DbConfiguration> options)
        {
            _connectionString = options.Value.ConnectionString;
        }

        protected IDbConnection ProvideConnection() => new SqlConnection(_connectionString);
    }
}