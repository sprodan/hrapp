//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRAPP.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class CriterionType
    {
        public CriterionType()
        {
            this.Criterion = new HashSet<Criterion>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Criterion> Criterion { get; set; }
    }
}
