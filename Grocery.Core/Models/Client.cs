namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        public string EmailAddress { get; private set; }
        private string _password { get; }

        public Client(int id, string name, string emailAddress, string password) : base(id, name)
        {
            EmailAddress = emailAddress;
            _password = password;
        }

        internal bool VerifyPassword(string password)
        {
            return _password == password;
        }
    }
}