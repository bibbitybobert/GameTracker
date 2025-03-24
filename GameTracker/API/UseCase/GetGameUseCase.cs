using GameTracker.API.DataAccess;
using FluentResults;

namespace GameTracker.API.UseCase;

public interface IGetGameUseCase
{
    Task<Result<IReadOnlyList<Entities.Game>>> GetAllGames();
}

public class GetGameUseCase: IGetGameUseCase
{
    IDatabaseAccess _databaseAccess;
    public GetGameUseCase(
        IDatabaseAccess databaseAccess)
    {
        _databaseAccess = databaseAccess;
    }

    public async Task<Result<IReadOnlyList<Entities.Game>>> GetAllGames()
    {
        try
        {
            var games = await _databaseAccess.GetAllGames();
        }
        catch (Exception ex)
        {
            return new Error($"An error occured when attempting to get all games: {ex}");
        }
    }
}
