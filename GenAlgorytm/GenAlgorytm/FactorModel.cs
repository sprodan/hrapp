using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenAlgorytm
{
    public class FactorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CriterionModel> Criterias { get; set; } 
    }
}
