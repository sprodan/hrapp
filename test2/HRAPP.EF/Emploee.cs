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
    
    public partial class Emploee
    {
        public Emploee()
        {
            this.EmploeeCriterion = new HashSet<EmploeeCriterion>();
            this.EmploeeGroup = new HashSet<EmploeeGroup>();
            this.EmploeePositions = new HashSet<EmploeePosition>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    
        public virtual ICollection<EmploeeCriterion> EmploeeCriterion { get; set; }
        public virtual ICollection<EmploeeGroup> EmploeeGroup { get; set; }
        public virtual ICollection<EmploeePosition> EmploeePositions { get; set; }
    }
}
