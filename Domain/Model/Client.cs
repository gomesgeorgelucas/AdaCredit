namespace AdaCredit.Domain.Model
{

    public sealed class Client : User
    {
        public Account Account { get; set; }

        private readonly string _id;

        public Client(string name, string cpf, string username = "user", string password = "pass") : base(name, cpf, username, password)
        {
        }
    }
}
