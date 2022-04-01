using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    class User : IAccount
    {
        static private int _id = 0;
        private string _password;
        private string _fullname;
        public int Id { get; }
        public string FullName {
            get { return _fullname; }
            set
            {
                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value))
                {
                    _fullname = value.Trim();
                }
                else throw new Exception("Fullname Cant be empty");
            }
        }
        public string Email { get; set; }
        public string Password
        {
            get { return _password; }
            set
            {
                if(PasswordChecker(value))
                    _password = value;
                else throw new Exception("Invalid Password Format");
            }
        }
        public User(string email, string password) 
        {
            Email = email;
            Password = password;
            Id = _id;
            _id++;
        }
        public User(string fullname, string email, string password) : this(email, password)
        {
            FullName = fullname;
        }

        public bool PasswordChecker(string password)
        {
            if (!String.IsNullOrEmpty(password) || !String.IsNullOrWhiteSpace(password) || password.Length >= 8)
            {
                bool isDigit = false;
                bool isUpper = false;
                bool isLower = false;
                foreach (var letter in password)
                {
                    if (char.IsDigit(letter)) isDigit = true;
                    else if (char.IsUpper(letter)) isUpper = true;
                    else if (char.IsLower(letter)) isLower = true;

                    if (isDigit && isLower && isUpper) return true;
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"-----------------------\nId:{Id}\nFullName:{FullName}\nEmail:{Email}");
        }
    }
}
