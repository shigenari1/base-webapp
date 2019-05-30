using System;
using src.UseCase.User.Create;

namespace src.ConsoleApp.User.Create
{
    /// <summary>
    /// Presenter 表現の違いを吸収するオブジェクト
    /// </summary>
    public class UserCreatePresenter : IUserCreatePresenter
    {
        public void Complete(UserCreateOutputData outputData)
        {
            var userId = outputData.UserId;
            var createdDate = outputData.Created;
            var createdDateText = createdDate.ToString("yyyy/MM/dd");
            var model = new UserCreateViewModel(userId, createdDateText);
            Console.WriteLine("id:" + model.UserId + " created:" + model.CreatedDate);
        }
    }

}