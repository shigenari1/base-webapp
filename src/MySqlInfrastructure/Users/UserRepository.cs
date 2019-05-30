using System.Collections.Generic;
using src.Domain.Domain.Users;
using MySql.Data.MySqlClient;

namespace src.MySqlInfrastructure.Users
{
    public class UserRepository : IUserRepository
    {
        public void Save(User user)
        {
            using (var con = new MySqlConnection(Config.ConnectionString))
            {
                con.Open();

                bool isExist;
                using (var com = con.CreateCommand())
                {
                    com.CommandText = "SELECT * FROM t_user WHERE id = @id";
                    com.Parameters.Add(new MySqlParameter("@id", user.Id));
                    var reader = com.ExecuteReader();
                    isExist = reader.Read();
                }

                using (var command = con.CreateCommand()){
                    command.CommandText = isExist
                        ? "UPDATE t_user SET username = @username WHERE id = @id"
                        : "INSERT INTO t_user VALUES(@id, @username)";
                    command.Parameters.Add(new MySqlParameter("@id", user.Id));
                    command.Parameters.Add(new MySqlParameter("@username", user.UserName));
                    command.ExecuteNonQuery();
                }
            }

        }

        public User FindByUserName(string userName)
        {
            return null;
        }

        public IEnumerable<User> FindAll()
        {
            return null;
        }
    }
}