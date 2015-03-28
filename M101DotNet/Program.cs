using System;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

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
          var doc = new BsonDocument
          {
            {"name", "Jones"}
          };
          doc.Add("age", 30);
          doc["profession"] = "hacker";
          var nestedArray = new BsonArray();
          nestedArray.Add(new BsonDocument("color", "red"));
          doc.Add("array", nestedArray);
          Console.WriteLine(doc);
        }
    }
}