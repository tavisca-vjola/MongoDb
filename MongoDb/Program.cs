using Database;
using Database.FileOperation;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.IO;

namespace MongoDb
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the path of the file");
            string Path = Console.ReadLine();
            var file = new FileOperation();
            var unParsed = file.ReadAllRegions(Path);
            var parser = new Parser();
            var regions = parser.RawRegionsToLocations(unParsed);

            RegionService regionService = new RegionService("elastic");
            regionService.AddRegionsToDatabase(regions);




            




        }
    }
}
