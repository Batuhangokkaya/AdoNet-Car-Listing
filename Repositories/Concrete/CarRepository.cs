using Entities.Models;
using Repositories.Abstract;
using System.Data.SqlClient;

namespace Repositories.Concrete
{
    public class CarRepository : ICarRepository
    {
        public void Add(Car entity)
        {
            using (var db = new RepositoryContext())
            {
                string query   = "INSERT INTO Cars (BrandName, ModelName, Year, Price, FuelType, Transmission, Mileage, Color) VALUES (@brandName, @modelName, @year, @price, @fuelType, @transmission, @mileage, @color)";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@brandName", entity.BrandName);
                cmd.Parameters.AddWithValue("@modelName", entity.ModelName);
                cmd.Parameters.AddWithValue("@year", entity.Year);
                cmd.Parameters.AddWithValue("@price", entity.Price);
                cmd.Parameters.AddWithValue("@fuelType", entity.FuelType);
                cmd.Parameters.AddWithValue("@transmission", entity.Transmission);
                cmd.Parameters.AddWithValue("@mileage", entity.Mileage);
                cmd.Parameters.AddWithValue("@color", entity.Color);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var db = new RepositoryContext())
            {
                string query = "DELETE FROM Cars WHERE CarID = @carID";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@carID", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Car entity)
        {
            using (var db = new RepositoryContext())
            {
                string query   = "UPDATE Cars SET BrandName = @brandName, ModelName = @modelName, Year = @year, Price = @price, FuelType = @fuelType, Transmission = @transmission, Mileage = @mileage, Color = @color WHERE CarID = @carID";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@carID", entity.CarID);
                cmd.Parameters.AddWithValue("@brandName", entity.BrandName);
                cmd.Parameters.AddWithValue("@modelName", entity.ModelName);
                cmd.Parameters.AddWithValue("@year", entity.Year);
                cmd.Parameters.AddWithValue("@price", entity.Price);
                cmd.Parameters.AddWithValue("@fuelType", entity.FuelType);
                cmd.Parameters.AddWithValue("@transmission", entity.Transmission);
                cmd.Parameters.AddWithValue("@mileage", entity.Mileage);
                cmd.Parameters.AddWithValue("@color", entity.Color);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();

            using (var db = new RepositoryContext())
            {
                string query   = "SELECT * FROM Cars";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Car car = new Car
                    {
                        CarID        = (int)reader["CarID"],
                        BrandName    = reader["BrandName"].ToString(),
                        ModelName    = reader["ModelName"].ToString(),
                        Year         = (int)reader["Year"],
                        Price        = (decimal)reader["Price"],
                        FuelType     = reader["FuelType"].ToString(),
                        Transmission = reader["Transmission"].ToString(),
                        Mileage      = (int)reader["Mileage"],
                        Color        = reader["Color"].ToString()
                    };
                    cars.Add(car);
                }
            }
            return cars;
        }

        public Car GetByIdCar(int id)
        {
            using (var db = new RepositoryContext())
            {
                string query   = "SELECT * FROM Cars WHERE CarID = @carID";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("carID", id);

                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Car
                    {
                        CarID        = (int)reader["CarID"],
                        BrandName    = reader["BrandName"].ToString(),
                        ModelName    = reader["ModelName"].ToString(),
                        Year         = (int)reader["Year"],
                        Price        = (decimal)reader["Price"],
                        FuelType     = reader["FuelType"].ToString(),
                        Transmission = reader["Transmission"].ToString(),
                        Mileage      = (int)reader["Mileage"],
                        Color        = reader["Color"].ToString(),
                    };
                }
            }
            return null;
        }
        
        public List<Brand> GetAllBrands()
        {
            List<Brand> brands = new List<Brand>();

            using (var db = new RepositoryContext())
            {
                string query = "SELECT * FROM Brands";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Brand brand = new Brand
                    {
                        BrandID   = (int)reader["BrandID"],
                        BrandName = reader["BrandName"].ToString()
                    };
                    brands.Add(brand);
                }
            }
            return brands;
        }

        public List<Model> GetAllModels()
        {
            List<Model> models = new List<Model>();

            using (var db = new RepositoryContext())
            {
                string query = "SELECT * FROM Models";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Model model = new Model
                    {
                        ModelID   = (int)reader["ModelID"],
                        ModelName = reader["ModelName"].ToString()
                    };
                    models.Add(model);
                }
            }
            return models;
        }

        public List<FuelType> GetAllFuelTypes()
        {
            List<FuelType> fuelTypes = new List<FuelType>();

            using (var db = new RepositoryContext())
            {
                string query = "SELECT * FROM FuelTypes";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    FuelType fuelType = new FuelType
                    {
                        ID   = (int)reader["ID"],
                        Fuel = reader["Fuel"].ToString()
                    };
                    fuelTypes.Add(fuelType);
                }
            }
            return fuelTypes;
        }

        public List<Transmission> GetAllTransmissions()
        {
            List<Transmission> transmissions = new List<Transmission>();

            using (var db = new RepositoryContext())
            {
                string query = "SELECT * FROM Transmissions";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Transmission transmission = new Transmission
                    {
                        ID               = (int)reader["ID"],
                        TransmissionName = reader["TransmissionName"].ToString()
                    };
                    transmissions.Add(transmission);
                }
            }
            return transmissions;
        }
    }
}