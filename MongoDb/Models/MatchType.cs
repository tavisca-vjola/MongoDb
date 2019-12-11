using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class MatchType
    {
        public MatchType()
        {
            Values = new Dictionary<string, Object>();
        }
       public Dictionary<string, Object> Values { get; private set; }
    }
}
