//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SofaProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Price
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Price()
        {
            this.OrderDetails = new HashSet<OrderDetails>();
        }
    
        public int ID_Price { get; set; }
        public int ID_Group { get; set; }
        public string Title { get; set; }
        public string Size { get; set; }
        public int TimeCraft { get; set; }
        public decimal Price1 { get; set; }
        public string Foto { get; set; }
        public string Description { get; set; }
        public string InStock { get; set; }
    
        public virtual GroupProduct GroupProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
