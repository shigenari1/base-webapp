namespace src.ConsoleApp.User.Create
{
    public class UserCreateViewModel
    {
        private string userId;
        private string createdDate;

        public UserCreateViewModel(string userId, string createDate)
        {
            UserId = userId;
            CreatedDate = createDate;
        }

        public string UserId {get;}
        public string CreatedDate {get;}
    }
}