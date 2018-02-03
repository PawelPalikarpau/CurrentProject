using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int AccountId { get; set; }

        public UserModel()
        {

        }

        public UserModel(string email, string password, string role)
        {
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
