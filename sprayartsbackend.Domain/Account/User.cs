using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace sprayartsbackend.Domain.Account
{
    public class User : Entity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string userName, string email, string password)
        {
            ValidateNameAndSetName(userName);
            ValidateEmailAndSetEmail(email);
            ValidatePasswordAndSetPassword(password);
        }

        public void Update(string userName, string email, string password)
        {
            ValidateNameAndSetName(userName);
            ValidateEmailAndSetEmail(email);
            ValidatePasswordAndSetPassword(password);
        }

        private void ValidateNameAndSetName(string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is Required");
            DomainException.When(name.Length < 3, "Name invalid");
            UserName = name;
        }

        private void ValidateEmailAndSetEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            DomainException.When(string.IsNullOrEmpty(email), "Name is Required");
            DomainException.When(!match.Success, "Emailinvalid");
            Email = email;
        }


        private void ValidatePasswordAndSetPassword(string password)
        {
            DomainException.When(string.IsNullOrEmpty(password), "Password is Required");
            DomainException.When(password.Length < 6, "Password invalid");
            Password = password;
        }
    }
}
