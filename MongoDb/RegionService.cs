using Database.Interfaces;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class RegionService
    {
        private readonly IDatabase _database;

        public RegionService(string DbName)
        {
            _database = DbStoreFactory.SelectDatabase(DbName);
        }
        public void AddRegionsToDatabase(List<Region> regions)
        {
            foreach(var region in regions)
            {
                _database.AddtoDatabase(region);
            }
        }
    }
}
