using System;
using System.Threading.Tasks;
using MongoDB.Driver;

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
            var client = new MongoClient();
        }
    }
}