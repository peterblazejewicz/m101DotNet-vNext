using System.Collections.Generic;
using MongoDB.Bson;

namespace M101DotNet
{
    public class Person
    {
      public ObjectId id { get; set; }
      
      public string Name { get; set; }
      
      public int Age { get; set; }
      
      public List<string> Colors {get; set; }
      
      public List<Pet> Pets { get; set; }
      
      public BsonDocument ExtraElement { get; set; }
      
    }
}