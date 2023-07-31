using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Serialize_Deserialize
{
    internal class Restoran
    {
        public string RestoranName { get; set; }
        public IList <Coustumer> Coustumers { get; set; }
    }
}
