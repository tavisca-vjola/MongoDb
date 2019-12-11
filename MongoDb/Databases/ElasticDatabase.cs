using Database.Interfaces;
using Database.Models;
using Elasticsearch.Net;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Databases
{
    public class ElasticDatabase : IDatabase
    {
        SingleNodeConnectionPool pool;
        ConnectionSettings connectionSettings;
        ElasticClient client;

        public void AddtoDatabase(Region region) {
            pool = new SingleNodeConnectionPool(new Uri("http://localhost:9200"));
            connectionSettings = new ConnectionSettings(pool).DefaultMappingFor<Region>(m => m.IndexName("region"));
            

            connectionSettings.DefaultIndex("RegionID");
            client = new ElasticClient(connectionSettings);
            IndexSettings settings = new IndexSettings { NumberOfReplicas = 1, NumberOfShards = 1 };
            IndexState indexConfig = new IndexState { Settings = settings };
           
            //Console.Read();
            var result = client.Bulk(b => b.Index<Region>(i => i.Document(region))
                                           .Create<Region>(c => c.Document(region))
                                     );





        }

        
    }
}
