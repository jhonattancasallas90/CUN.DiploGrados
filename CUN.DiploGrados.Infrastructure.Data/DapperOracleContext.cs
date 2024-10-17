using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CUN.DiploGrados.Infrastructure.Data
{
    public class DapperOracleContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _oracleString;

        public DapperOracleContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _oracleString = configuration.GetConnectionString("OracleConnection");

        }
        public IDbConnection CreateConnectionOracle() => new OracleConnection(_oracleString);
    }
}
