
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharing.Classes
{
    public class Repository
    {
        public List<Model.Model> Models { get; set; }
        public List<Model.Car> Cars { get; set; }

        public Repository()
        {
            //Models = new List<Model.Model>()
            //{
            //new Model.Model
            //{
            //    Id = 2,
            //    Name = "Kia",
            //    Rate = 7
            //},
            //new Model.Model
            //{
            //    Id = 10,
            //    Name = "BMW",
            //    Rate = 10
            //}
            //};
            //Cars = new List<Model.Car>()
            //{
            //new Model.Car
            //{
            //    Model = Models[0],
            //    ModelId = Models[0].Id,
            //    FuelLeft = 90,
            //    IsAvailable = true,
            //    Location = new Model.Location{ Latitude = 55.778740, Longitude = 37.732647 },
            //    Rating = 7
            //},
            //new Model.Car
            //{
            //    Model = Models[0],
            //    ModelId = Models[0].Id,
            //    FuelLeft = 45,
            //    IsAvailable = false,
            //    Location = new Model.Location{ Latitude = 55.778760, Longitude = 37.734647 },
            //    Rating = 8
            //},
            //new Model.Car
            //{
            //    Model = Models[1],
            //    ModelId = Models[1].Id,
            //    FuelLeft = 28,
            //    IsAvailable = true,
            //    Location = new Model.Location{ Latitude = 55.678740, Longitude = 37.742647 },
            //    Rating = 10
            //},
            //new Model.Car
            //{
            //    Model = Models[1],
            //    ModelId = Models[1].Id,
            //    FuelLeft = 99,
            //    IsAvailable = true,
            //    Location = new Model.Location{ Latitude = 55.778740, Longitude = 37.782647 },
            //    Rating = 9
            //}

            //};

            //Save();
            Restore();
        }

        private List<T> RestoreList<T>(string fileName)
        {
            using (var sr = new StreamReader(fileName))
            {
                using (var reader = new JsonTextReader(sr))
                {
                    var serializer = new JsonSerializer();

                    return serializer.Deserialize<List<T>>(reader);
                }
            }
        }

        private void Restore()
        {
            Models = RestoreList<Model.Model>("models.json");
            Cars = RestoreList<Model.Car>("cars.json");

            foreach (var car in Cars)
                car.Model = Models.FirstOrDefault(m => m.Id == car.ModelId);

            // Restoring references from cars to models
        }

        private void SaveList<T>(string fileName, List<T> list)
        {
            using (var sw = new StreamWriter(fileName))
            {
                using (var writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;

                    var serializer = new JsonSerializer();
                    serializer.Serialize(writer, list);
                }
            }
        }

        public void Save()
        {
            SaveList("models.json", Models);
            SaveList("cars.json", Cars);
        }
    }
}
