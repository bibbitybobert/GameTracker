using GameTracker.API.UseCase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracker.API.Controller;

public interface IGameController
{
    Task<IReadOnlyList<Entities.Game>> GetAllGames();
}

public class GameController : IGameController
{
    private IGetGameUseCase _getGameUseCase;
    private ICreateGameUseCase _createGameUseCase;
    private IUpdateGameUsecase _updateGameUsecase;
    public GameController(
        IGetGameUseCase getGameUseCase,
        ICreateGameUseCase createGamesUseCase,
        IUpdateGameUsecase updateGameUsecase
        )
    {
        _getGameUseCase = getGameUseCase;
        _createGameUseCase = createGamesUseCase;
        _updateGameUsecase = updateGameUsecase;
    }

    public async Task<IReadOnlyList<Entities.Game>> GetAllGames()
    {
        try
        {
            return await _getGameUseCase.GetAllGames();
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"An error occured when getting all games: {ex}");
            return null;
        }
    }
}
