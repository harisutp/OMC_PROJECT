using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMC_PROJECT
{
    public static class UserStore
    {
        private static readonly List<User> _users = new List<User>();

        public static bool TryRegister(string name, string email, string password, string disabilities, out string error)
        {
            if (_users.Any(u => u.Email.Equals(email, System.StringComparison.OrdinalIgnoreCase)))
            {
                error = "An account with this email already exists.";
                return false;
            }

            _users.Add(new User
            {
                Name = name,
                Email = email,
                Password = password,
                Disabilities = disabilities
            });

            error = null;
            return true;
        }

        public static bool TryLogin(string email, string password, out User user, out string error)
        {
            user = _users.FirstOrDefault(u =>
                u.Email.Equals(email, System.StringComparison.OrdinalIgnoreCase) &&
                u.Password == password);

            if (user == null)
            {
                error = "Invalid email or password.";
                return false;
            }

            error = null;
            return true;
        }
    }
}
