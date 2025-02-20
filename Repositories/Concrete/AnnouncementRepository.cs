using Entities.Models;
using Repositories.Abstract;
using System.Data.SqlClient;

namespace Repositories.Concrete
{
    public class AnnouncementRepository : IAnnouncementRepository
    {
        public void AddAd(Announcement announcement)
        {
            using (var db = new RepositoryContext())
            {
                db.GetConnection();
                string query = "INSERT INTO Announcements (CarID, UserID, Description, Location, AnnouncementAt, Status) VALUES (@carID, @userID, @description, @location, @announcementAt, @status)";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@carID", announcement.CarID);
                cmd.Parameters.AddWithValue("@userID", announcement.UserID);
                cmd.Parameters.AddWithValue("@description", announcement.Description);
                cmd.Parameters.AddWithValue("@location", announcement.Location);
                cmd.Parameters.AddWithValue("@announcementAt", DateTime.Now);
                cmd.Parameters.AddWithValue("@status", announcement.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAd(Announcement announcement)
        {
            using (var db = new RepositoryContext())
            {
                db.GetConnection();
                string query = "UPDATE Announcements SET CarID = @carID, Description = @description, Location = @location, AnnouncementAt = @announcementAt, Status = @status WHERE AnnouncementID = @announcementID";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@announcementID", announcement.AnnouncementID);
                cmd.Parameters.AddWithValue("@carID", announcement.CarID);
                cmd.Parameters.AddWithValue("@description", announcement.Description);
                cmd.Parameters.AddWithValue("@location", announcement.Location);
                cmd.Parameters.AddWithValue("@announcementAt", DateTime.Now);
                cmd.Parameters.AddWithValue("@status", announcement.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAd(int announcementID)
        {
            using (var db = new RepositoryContext())
            {
                db.GetConnection();
                string query = "DELETE FROM Announcements WHERE announcementID = @announcementID";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@announcementID", announcementID);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Announcement> GetAllAnnouncements(int userID)
        {
            List<Announcement> announcements = new List<Announcement>();

            using (var db = new RepositoryContext())
            {
                string query = "SELECT AnnouncementID, CarID, Description, Location, AnnouncementAt, Status FROM Announcements WHERE UserID = @userID";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@userID", userID);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Announcement announcement = new Announcement
                    {
                        AnnouncementID = (int)reader["AnnouncementID"],
                        CarID          = (int)reader["CarID"],
                        Description    = reader["Description"].ToString(),
                        Location       = reader["Location"].ToString(),
                        AnnouncementAt = (DateTime)reader["AnnouncementAt"],
                        Status         = reader["Status"].ToString()
                    };
                    announcements.Add(announcement);
                }
                db.GetConnection().Close();
            }
            return announcements;
        }

        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();

            using (var db = new RepositoryContext())
            {
                string query = "SELECT * FROM Cars";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                db.GetConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Car listing = new Car
                    {
                        CarID = (int)reader["CarID"],
                    };
                    cars.Add(listing);
                }
                db.GetConnection().Close();
            }
            return cars;
        }

        public List<Location> GetAllLocations()
        {
            List<Location> locations = new List<Location>();

            using (var db = new RepositoryContext())
            {
                string query = "SELECT * FROM Locations";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                db.GetConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Location listing = new Location
                    {
                        ID = (int)reader["ID"],
                        LocationName = reader["LocationName"].ToString()
                    };
                    locations.Add(listing);
                }
                db.GetConnection().Close();
            }
            return locations;
        }

        public List<CarWithAnnouncement> GetAllAdAndCar()
        {
            List<CarWithAnnouncement> carWithListings = new List<CarWithAnnouncement>();

            using (var db = new RepositoryContext())
            {
                string query = "SELECT C.BrandName, C.ModelName, C.Year, C.Price, C.FuelType, C.Transmission, C.Mileage, C.Color, A.AnnouncementID, A.Description, A.Location, A.AnnouncementAt, A.Status, U.FirstName, U.LastName, U.Phone FROM Announcements A JOIN Cars C ON A.CarID = C.CarID JOIN Users U ON A.UserID = U.UserID";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                db.GetConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CarWithAnnouncement carWithListing = new CarWithAnnouncement
                    {

                        AnnouncementID = (int)reader["AnnouncementID"],
                        FirstName      = reader["FirstName"].ToString(),
                        LastName       = reader["LastName"].ToString(),
                        Phone          = reader["Phone"].ToString(),
                        BrandName      = reader["BrandName"].ToString(),
                        ModelName      = reader["ModelName"].ToString(),
                        Year           = (int)reader["Year"],
                        Price          = (decimal)reader["Price"],
                        FuelType       = reader["FuelType"].ToString(),
                        Transmission   = reader["Transmission"].ToString(),
                        Mileage        = (int)reader["Mileage"],
                        Color          = reader["Color"].ToString(),
                        Description    = reader["Description"].ToString(),
                        Location       = reader["Location"].ToString(),
                        AnnouncementAt = (DateTime)reader["AnnouncementAt"],
                        Status         = reader["Status"].ToString()
                    };
                    carWithListings.Add(carWithListing);
                }
                db.GetConnection().Close();
            }
            return carWithListings;
        }

        public CarWithAnnouncement GetByIdAdAndCar(int id)
        {
            using (var db = new RepositoryContext())
            {
                string query = $"SELECT * FROM Announcements A JOIN Cars C ON A.CarID = C.CarID JOIN Users U ON A.UserID = U.UserID WHERE AnnouncementID = {id}";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                db.GetConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new CarWithAnnouncement
                    {
                        FirstName      = reader["FirstName"].ToString(),
                        LastName       = reader["LastName"].ToString(),
                        Phone          = reader["Phone"].ToString(),
                        AnnouncementID = (int)reader["AnnouncementID"],
                        BrandName      = reader["BrandName"].ToString(),
                        ModelName      = reader["ModelName"].ToString(),
                        Year           = (int)reader["Year"],
                        Price          = (decimal)reader["Price"],
                        FuelType       = reader["FuelType"].ToString(),
                        Transmission   = reader["Transmission"].ToString(),
                        Mileage        = (int)reader["Mileage"],
                        Color          = reader["Color"].ToString(),
                        Description    = reader["Description"].ToString(),
                        Location       = reader["Location"].ToString(),
                        AnnouncementAt = (DateTime)reader["AnnouncementAt"],
                        Status         = reader["Status"].ToString()
                    };
                }
                db.GetConnection().Close();
            }
            return null;
        }
    }
}