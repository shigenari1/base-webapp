namespace src.UseCase.User.Create
{
    /// <summary>
    /// UseCase ユーザ登録処理
    /// </summary>
    public interface IUserCreateUseCase{
        void Handle(UserCreateInputData inputData);
    }
}