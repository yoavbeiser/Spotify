using System;
namespace Spotify
{
    public class User
    {
        private readonly string _name;
        private readonly string _mail;
        private readonly string _password;
        private readonly TypeUser _typeUser;
        public User(string name, string mail, string password, TypeUser typeUser)
        {
            _name = name;
            _mail = mail;
            _password = password;
            _typeUser = typeUser;
        }

    }
}
