using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public string ScaleType { get; set; }
        public string Habitat { get; set; }
        public bool ColdBlooded { get; set; }
        public string DietType { get; set; }
    }
}
