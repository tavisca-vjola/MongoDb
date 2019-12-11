using Database.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Database
{
    public class Parser
    {
        public List<Region> RawRegionsToLocations(List<string>unParsedString)
        {
            var allRegions = new List<Region>();
            for(int i=1;i<unParsedString.Count;i++)
            {
                allRegions.Add(RawRegionsToLocation(unParsedString[i]));
            }
            return allRegions;
        }

        private Region RawRegionsToLocation(string region)
        {
            var splitString = region.Split('|');
            var regoin = new Region();
            try
            {
                regoin.RegionId = BigInteger.Parse(splitString[0].TrimStart().TrimEnd());
                regoin.RegionName = splitString[1].TrimStart().TrimEnd();
                regoin.RegionNameLongitude = splitString[2].TrimStart().TrimEnd();
                regoin.Latitude = double.Parse(splitString[3].TrimStart().TrimEnd());
                regoin.Longitude = double.Parse(splitString[4].TrimStart().TrimEnd());
                regoin.SubClassification = splitString[5].TrimStart().TrimEnd() ?? "regional";
            }
            catch(Exception exception)
            {
                throw new Exception();
            }
            return regoin;
        }
    }
}
