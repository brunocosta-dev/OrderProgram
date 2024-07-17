using System;


namespace Course.Entities
{
    public class Client
    {
        public string? NameClient { get; set; }
        public string? Email { get; set; }
        public DateTime Birth { get; set; }

        public Client(string nameClient, string email, DateTime birth)
        {
            NameClient = nameClient;
            Email = email;
            Birth = birth;
        }

    }
}  