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
    
    public partial class Group
    {
        public Group()
        {
            this.EmploeeGroup = new HashSet<EmploeeGroup>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
    
        public virtual Company Companies { get; set; }
        public virtual ICollection<EmploeeGroup> EmploeeGroup { get; set; }
    }
}
