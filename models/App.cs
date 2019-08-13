using System.Collections.Generic;

namespace fakelogin.Models
{
    class App
    {
        public User ActiveUser { get; private set; }
        private Dictionary<string, User> Users { get; set; }

        public void AddUser(User user)
        {
            Users.Add(user.Name.ToLower(), user);
        }

        public bool Login(string name, string pass)
        {

            if (Users.ContainsKey(name) && Users[name].ValidatePassword(pass))
            {
                ActiveUser = Users[name];
                return true;
            }
            return false;
        }

        public App()
        {
            Users = new Dictionary<string, User>();
        }

    }
}

