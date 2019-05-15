using System.ComponentModel.DataAnnotations.Schema;

namespace HW2.Core.user
{
    [Table("Users")]
    public class User
    {
        //public User(int id, string username, string email, string password)
        //{
        //    Id = id;
        //    Username = username;
        //    Email = email;
        //    Password = password;
        //}

        public int Id { get; set;  }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}