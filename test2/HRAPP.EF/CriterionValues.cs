//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRAPP.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class CriterionValues
    {
        public int Id { get; set; }
        public int CriterionId { get; set; }
        public string Value { get; set; }
        public short Sort { get; set; }
    
        public virtual Criterion Criterion { get; set; }
    }
}