using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
namespace Registration.Domain
{
    public class User:IAccount, IUserInfo
    {
        private static int nextId = 1;
        public int Id { get; }
        public string Fullname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public User(string fullName, string email, string password)
        {
            Id = nextId;
            nextId++; 
            Fullname = fullName;
            Email = email;
            Password = password;
        }
        public bool PasswordChecker()
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
           Regex regex = new Regex(pattern);
            return regex.IsMatch(Password);
        }
        public virtual string UserInfo()
        {
            return (Id + " " + Fullname + " " + Email);
        }
    }
}