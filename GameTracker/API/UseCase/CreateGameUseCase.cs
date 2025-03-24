using GameTracker.API.DataAccess;

namespace GameTracker.API.UseCase;

public interface ICreateGameUseCase
{

}

public class CreateGameUseCase : ICreateGameUseCase
{
    IDatabaseAccess _databaseAccess;
    public CreateGameUseCase(
        IDatabaseAccess databaseAccess)
    {
        _databaseAccess = databaseAccess;
    }
}
