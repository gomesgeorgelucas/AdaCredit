namespace AdaCredit.Domain.Model
{
    public class Account
    {
        public string Number { get; set; }
        public string Agency { get; set; }

        private readonly string _id;

        private Client client { get; set; }


    }
}
