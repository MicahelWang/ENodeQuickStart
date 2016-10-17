using ENode.Eventing;

namespace ENodeQuickStart.Domain.Accounts
{
    public class RegisterAccountEvent:DomainEvent<string>
    {
        public string Name { get; private set; }
        public string  Password { get; private set; }

        private RegisterAccountEvent(){
        }

        public RegisterAccountEvent(string name,string password)
        {
            this.Name = name;
            this.Password = password;
        }

    }
}