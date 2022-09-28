﻿using System.Data.Common;
using System.Data;
using Dapper;

namespace Blazor_manyTomany_Dapper.Interfaces
{
    public interface IDapperService : IDisposable
    {
        DbConnection GetConnection();
        T Get<T>(string sp, DynamicParameters parms,
            CommandType commandType = CommandType.StoredProcedure);
        List<T> GetAll<T>(string sp, DynamicParameters parms,
            CommandType commandType = CommandType.StoredProcedure);
        int Execute(string sp, DynamicParameters parms,
            CommandType commandType = CommandType.StoredProcedure);
        T Insert<T>(string sp, DynamicParameters parms,
            CommandType commandType = CommandType.StoredProcedure);
        T Update<T>(string sp, DynamicParameters parms,
            CommandType commandType = CommandType.StoredProcedure);
    }
}