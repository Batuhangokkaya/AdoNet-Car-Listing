using System.ComponentModel;

namespace Entities.Models
{
    public class CarWithAnnouncement
    {
        [DisplayName("İlan Numarası")]
        public int AnnouncementID { get; set; }
        [DisplayName("Ad")]
        public string FirstName { get; set; }
        [DisplayName("Soyad")]
        public string LastName { get; set; }
        [DisplayName("Telefon")]
        public string Phone { get; set; }
        [DisplayName("Marka")]
        public string BrandName { get; set; }
        [DisplayName("Model")]
        public string ModelName { get; set; }
        [DisplayName("Yıl")]
        public int Year { get; set; }
        [DisplayName("Fiyat")]
        public decimal Price { get; set; }
        [DisplayName("Yakıt Türü")]
        public string FuelType { get; set; }
        [DisplayName("Vites Türü")]
        public string Transmission { get; set; }
        [DisplayName("Kilometre")]
        public int Mileage { get; set; }
        [DisplayName("Renk")]
        public string Color { get; set; }
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