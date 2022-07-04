namespace Authorization.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nick { get; set; }
    }
}
