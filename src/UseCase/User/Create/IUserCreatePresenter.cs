using System;

namespace src.UseCase.User.Create
{
    public interface IUserCreatePresenter
    {
        void Complete (UserCreateOutputData output);
    }
}