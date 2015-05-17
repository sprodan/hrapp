using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenAlgorytm
{
    class FactorModel
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public List<CriterionModel> Criterias { get; set; } 
    }
}
