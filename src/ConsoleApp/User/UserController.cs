using src.UseCase.User.Create;

namespace src.ConsoleApp.User
{
    public class UserController
    {
        private readonly IUserCreateUseCase userCreateUseCase;

        public UserController(IUserCreateUseCase userCreateUseCase)
        {
            this.userCreateUseCase = userCreateUseCase;
        }

        public void CreateUser(string userName)
        {
            var inputData = new UserCreateInputData(userName);
            userCreateUseCase.Handle(inputData);
        }
    }
}