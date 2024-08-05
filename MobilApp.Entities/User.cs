using System.ComponentModel.DataAnnotations;

namespace MobilApp.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public byte Type { get; set; }
        public string NameSurname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Eposta { get; set; }
        public string? LastToken { get; set; }
        public DateTime? TokenUseDate { get; set; }
        public bool IsActive { get; set; }
    }
}
