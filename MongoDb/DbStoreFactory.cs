using Database.Databases;
using Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public static class DbStoreFactory
    {
        public static IDatabase  SelectDatabase(string DbName)
        {
                switch(DbName.ToLower())
                {
                case "mongo":
                    return new MongoDatabases();
                case "elastic":
                    return new ElasticDatabase();
                default:
                    return new MongoDatabases();

                }

        }

    }
}
