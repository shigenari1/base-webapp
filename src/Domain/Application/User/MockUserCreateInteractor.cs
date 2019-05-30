using System;
using src.UseCase.User.Create;
using src.Domain.Domain.Users;
namespace src.Domain.Application.User
{
    /// <summary>
    /// テスト用ユーザ登録処理の実装
    /// </summary>
    public class MockUserCreateInteractor : IUserCreateUseCase
    {
        public static int id;
        private readonly IUserCreatePresenter presenter;
        
        public MockUserCreateInteractor(IUserRepository userRepository, IUserCreatePresenter presenter)
        {
            this.presenter = presenter;
        }

        /// <summary>
        /// ユーザ登録
        /// </summary>
        /// <param name="inputData"></param>
        public void Handle(UserCreateInputData inputData)
        {
            var outputData = new UserCreateOutputData((id++).ToString(), DateTime.Now);
            presenter.Complete(outputData);
        }
    }
}