namespace AdaCredit.Domain.Model
{
    public class User
    {
        protected readonly string _name;
        protected readonly string _cpf;
        protected string _username;
        protected string _password;
        protected string _salt;

        public User(string name, string cpf, string username = "user", string password = "pass", string salt = "")
        {
            _name = name;
            _cpf = cpf;
            _username = username;
            _password = password;
            _salt = salt;
        }

    }
}
