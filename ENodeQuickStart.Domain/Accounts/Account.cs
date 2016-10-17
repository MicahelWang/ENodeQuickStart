using System;
using ENode.Domain;
using ENodeQuickStart.Infrastructure;

namespace ENodeQuickStart.Domain.Accounts
{
    public class Account : AggregateRoot<string>
    {
        private string _name;
        private string _password;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Account(string name, string password)
        {
            Assert.IsNotNullOrWhiteSpace("账号", name);
            Assert.IsNotNullOrWhiteSpace("密码", password);
            if (name.Length>128)
            {
                throw new Exception("账号长度不能超过16");
            }
            if (password.Length > 128)
            {
                throw new Exception("密码长度不能超过128");
            }
           ApplyEvent(new RegisterAccountEvent(name,password));
        }

        private void Handle(RegisterAccountEvent evet)
        {
            _name = evet.Name;
            _password = evet.Password;
        }


    }
}