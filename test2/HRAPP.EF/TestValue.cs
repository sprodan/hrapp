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
    
    public partial class TestValue
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int TestItemId { get; set; }
        public string Sort { get; set; }
    
        public virtual TestItem TestItem { get; set; }
    }
}
