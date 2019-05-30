namespace src.UseCase.User.Create
{
    /// <summary>
    /// ユーザ登録　入力用パラメータ DTO
    /// </summary>
    public class UserCreateInputData
    {
        public UserCreateInputData(string userName)
        {
            UserName = userName;
        }

        public string UserName {get;}
    }
}