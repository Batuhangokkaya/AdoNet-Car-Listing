using System.ComponentModel;

namespace Entities.Models
{
    public class Announcement
    {
        [DisplayName("İlan Numarası")]
        public int AnnouncementID { get; set; }
        [DisplayName("Kullanıcı Numarası")]
        public int UserID { get; set; }
        [DisplayName("Araba Numarası")]
        public int CarID { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Konum")]
        public string Location { get; set; }
        [DisplayName("İlan Tarihi")]
        public DateTime AnnouncementAt { get; set; }
        [DisplayName("Durumu")]
        public string Status { get; set; }
    }
}