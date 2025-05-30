namespace CafeteriaKwai.Data.Models {
    public class Country {
        public int CountryId { get; set; }
        public string Name { get; set; }

        // Navigation property for related cities
        public ICollection<City> Cities { get; set; }
    }

    public class City {
        public int CityId { get; set; }
        public string Name { get; set; }

        // Foreign key for Country
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
