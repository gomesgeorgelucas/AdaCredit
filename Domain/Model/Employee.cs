namespace AdaCredit.Domain.Model
{
    public sealed class Employee : User
    {
        public Employee(string name, string cpf, string username = "user", string password = "pass") : base(name, cpf, username, password)
        {
        }
    }
}
