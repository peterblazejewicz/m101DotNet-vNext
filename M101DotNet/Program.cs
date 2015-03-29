using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.IO;

namespace M101DotNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainAsync(args).Wait();
            Console.WriteLine();
            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }
        
        static async Task MainAsync(string[] args)
        {
          var connectionString = "mongodb://localhost:27017";
          var client = new MongoClient(connectionString);
          var db = client.GetDatabase("test");
          var person = new Person
          {
            Name = "Jones",
            Age = 30,
            Colors = new List<string> {"red", "blue"},
            Pets = new List<Pet> 
            {
              new Pet
              {
                Name = "Puffy",
                Type = "Pig"
              }
            }
          };
          Console.WriteLine(person);
          using (var writer = new JsonWriter(Console.Out))
          {
            BsonSerializer.Serialize(writer, person);
          };
        }
    }
}