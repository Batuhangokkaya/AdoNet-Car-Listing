using System.ComponentModel;

namespace Entities.Models
{
    public class Car
    {
        [DisplayName("Araba Numarası")]
        public int CarID { get; set; }
        [DisplayName("Araba Markası")]
        public string BrandName { get; set; }
        [DisplayName("Araba Modeli")]
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
        [DisplayName("Araba Renki")]
        public string Color { get; set; }
    }
}