using System.ComponentModel;

namespace Entities.Models
{
    public class User
    {
        [DisplayName("Kullanıcı Numarası")]
        public int UserID { get; set; }
        [DisplayName("Ad")]
        public string FirstName { get; set; }
        [DisplayName("Soyad")]
        public string LastName { get; set; }
        [DisplayName("Kullnıcı Adı")]
        public string UserName { get; set; }
        [DisplayName("Şifre")]
        public string PasswordHash { get; set; }
        [DisplayName("E-Mail")]
        public string EMail { get; set; }
        [DisplayName("Telefon")]
        public string Phone { get; set; }
        [DisplayName("Yetki")]
        public string Role { get; set; }
        [DisplayName("Oluşturma Tarihi")]
        public string CreatedAt { get; set; }
    }
}