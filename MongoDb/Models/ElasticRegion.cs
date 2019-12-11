using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Database.Models
{
    public class ElasticRegion
    {
        public BigInteger? _id { get; set; }
        public BigInteger? RegionId { get; set; }
        public string RegionName { get; set; }
        public string RegionNameLongitude { get; set; }
    }
}
