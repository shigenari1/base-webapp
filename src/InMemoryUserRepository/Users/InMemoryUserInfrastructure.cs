using System.Collections.Generic;
using System.Linq;
using src.Domain.Domain.Users;

namespace src.InMemoryUserInfrastructure.Users
{
    /// <summary>
    /// インメモリレポジトリ
    /// </summary>
    public class InMemoryUserRepository : IUserRepository
    {

        private readonly Dictionary<string, User> data = new Dictionary<string, User>();

        public void Save(User user)
        {
            data[user.Id] = cloneUser(user);

        }

        public User FindByUserName(string userName)
        {
            return data.Select(x => x.Value).FirstOrDefault(x => x.UserName == userName);
        }

        public IEnumerable<User> FindAll()
        {
            return data.Values;
        }

        private User cloneUser(User user)
        {
            return new User(user.Id, user.UserName);
        }

    }
}