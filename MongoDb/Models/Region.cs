using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Database.Models
{
    public class Region
    {
        public BigInteger? RegionId { get; set; }
        public string RegionName { get; set; }
        public string RegionNameLongitude { get; set; }
        public double? Latitude { get; set; }
        public  double? Longitude { get; set; }
        public  string SubClassification { get; set; }

    }
}
