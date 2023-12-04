﻿using Npgsql;
using System.Data;
using System.Threading;

namespace Movies.Application.Database;

public interface IDbConnectionFactory
{
    Task<IDbConnection> CreateConnectionAsync(CancellationToken token = default);
}
public class NpgsqlconnectionFactory : IDbConnectionFactory
{
    private readonly string _connectionString;

    public NpgsqlconnectionFactory(string connectionString) => _connectionString = connectionString;

    public async Task<IDbConnection> CreateConnectionAsync(CancellationToken token = default)
    {
        var connection = new NpgsqlConnection(_connectionString);
        await connection.OpenAsync(cancellationToken: token);
        return connection;
    }
}
