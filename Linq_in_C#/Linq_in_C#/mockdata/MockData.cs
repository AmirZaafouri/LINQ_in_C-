using Linq_in_C_.POCO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_.MockData
{
    public class MockData
    {
        public static List<Person> GetPeople()
        {
            string json = ReadJsonFile("people.json");
            return JsonConvert.DeserializeObject<List<Person>>(json);
        }

        public static List<Car> GetCars()
        {
            string json = ReadJsonFile("car.json");
            return JsonConvert.DeserializeObject<List<Car>>(json);
        }

        private static string ReadJsonFile(string fileName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"resources", fileName);
            return File.ReadAllText(filePath);
        }

    }
}
