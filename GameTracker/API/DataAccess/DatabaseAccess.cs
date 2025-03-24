using MySql.Data.MySqlClient;
using System.Data.Common;

namespace GameTracker.API.DataAccess;

public interface IDatabaseAccess
{
    Task<IReadOnlyList<Entities.Game>> GetAllGames();
}

public class DatabaseAccess : IDatabaseAccess
{
    private DbConnection _dbConnection;
    public DatabaseAccess() { };

    private DbConnection ConntectToDB(string tableName)
    {
        if (_dbConnection == null)
        {
            if()
        }
    }

    public async Task<IReadOnlyList<Entities.Game>> GetAllGames()
    {
        _context = 
    }
}
