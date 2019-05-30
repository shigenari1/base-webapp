using System;
using src.UseCase.User.Create;
using src.Domain.Domain.Users;
namespace src.Domain.Application.User
{
    /// <summary>
    /// ユーザ登録処理の実装
    /// </summary>
    public class UserCreateInteractor : IUserCreateUseCase
    {
        private readonly IUserRepository userRepository;
        private readonly IUserCreatePresenter presenter;
        
        public UserCreateInteractor(IUserRepository userRepository, IUserCreatePresenter presenter)
        {
            this.userRepository = userRepository;
            this.presenter = presenter;
        }

        /// <summary>
        /// ユーザ登録
        /// </summary>
        /// <param name="inputData"></param>
        public void Handle(UserCreateInputData inputData)
        {
            var username = inputData.UserName;
            var duplicateUser = userRepository.FindByUserName(username);
            if (duplicateUser != null)
            {
                throw new Exception("duplicated");
            }

            var user = new src.Domain.Domain.Users.User(username);
            userRepository.Save(user);
            var outputData = new UserCreateOutputData(user.Id, DateTime.Now);
            presenter.Complete(outputData);
        }
    }
}