using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArbetsprovV2.Models
{
    [Serializable()]
    public class RecomendationQueryArg
    {
        public string Title { get; set; }
        public string Name { get; set; }
    }
}
