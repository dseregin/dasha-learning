using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.DataBase.Npgsql
{
    public abstract class BaseRepository
    {
        private string _connectionString;
        public BaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }

        protected async Task<NpgsqlConnection> OpenConnectionAsync()
        {
            var connection = new NpgsqlConnection(_connectionString);
            await connection.OpenAsync();
            return connection;
        }

        protected async Task<IEnumerable<T>> GetAwaitableDataCollectionLoader<T>(string sql)
        {
            IEnumerable<T> result = Enumerable.Empty<T>();

            using (var conn = await OpenConnectionAsync())
            {
                result = await conn.QueryAsync<T>(sql);
            }

            return result;
        }
        protected async Task<IEnumerable<T2>> GetAwaitableDataCollectionLoader<T, T1, T2>(string sql, Func<T, T1, T2> func)
        {
            IEnumerable<T2> result = Enumerable.Empty<T2>();

            using (var conn = await OpenConnectionAsync())
            {
                result = await conn.QueryAsync<T, T1, T2>(sql, func);
            }

            return result;
        }
        protected async Task<IEnumerable<T3>> GetAwaitableDataCollectionLoader<T, T1, T2, T3>(string sql, Func<T, T1, T2, T3> func)
        {
            IEnumerable<T3> result = Enumerable.Empty<T3>();

            using (var conn = await OpenConnectionAsync())
            {
                result = await conn.QueryAsync<T, T1, T2, T3>(sql, func);
            }

            return result;
        }
        protected async Task<IEnumerable<T4>> GetAwaitableDataCollectionLoader<T, T1, T2, T3, T4>(string sql, Func<T, T1, T2, T3, T4> func)
        {
            IEnumerable<T4> result = Enumerable.Empty<T4>();

            using (var conn = await OpenConnectionAsync())
            {
                result = await conn.QueryAsync<T, T1, T2, T3, T4>(sql, func);
            }

            return result;
        }

        protected async Task<int> AwaitableExecuteAsync(string sql)
        {
            int result = 0;

            using (var conn = await OpenConnectionAsync())
            {
                result = await conn.ExecuteAsync(sql);
            }

            return result;
        }

        protected async Task<int> AwaitableExecuteNoResultAsync(string sql)
        {
            int result = -1;

            using (var conn = await OpenConnectionAsync())
            {
                var executeQuery = new NpgsqlCommand(sql, conn);
                result = executeQuery.ExecuteNonQuery();
            }

            return result;
        }
    }
}
