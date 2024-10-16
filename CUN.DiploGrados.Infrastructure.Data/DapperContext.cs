using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CUN.DiploGrados.Infrastructure.Data
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _sqlString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _sqlString = configuration.GetConnectionString("SqlServerConnection");
        }

        public IDbConnection CreateConnectionSql() => new SqlConnection(_sqlString);
    }
}
