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
    
    public partial class EmploeeCriterion
    {
        public int Id { get; set; }
        public int EmploeeId { get; set; }
        public int CriterionId { get; set; }
        public string Value { get; set; }
    
        public virtual Emploee Emploees { get; set; }
        public virtual Criterion Criteria { get; set; }
    }
}
