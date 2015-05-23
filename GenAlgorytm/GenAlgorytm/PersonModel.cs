using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenAlgorytm
{
    public class PersonModel
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool TestPassed { get; set; }
            public List<CaracteristicModel> CaracteristicList { get; set; }
    }
}
