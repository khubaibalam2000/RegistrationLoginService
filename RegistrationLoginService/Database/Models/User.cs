namespace RegistrationLoginService.Database.Models
{
    public class User
    {
        public int userId { get; set; }
        public string name { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
    }
}
