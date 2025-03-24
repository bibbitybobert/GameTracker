using GameTracker.API.DataAccess;

namespace GameTracker.API.UseCase;

public interface IUpdateGameUsecase
{

}

public class UpdateGameUseCase: IUpdateGameUsecase
{
    IDatabaseAccess _databaseAccess;
    public UpdateGameUseCase(
        IDatabaseAccess databaseAccess)
    {
        _databaseAccess = databaseAccess;
    }
}
