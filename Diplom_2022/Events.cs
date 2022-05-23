//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom_2022
{
    using System;
    using System.Collections.Generic;
    
    public partial class Events
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Events()
        {
            this.Venue = new HashSet<Venue>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<int> SoldTicketsCount { get; set; }
        public Nullable<int> GainTicketsCount { get; set; }
        public Nullable<int> Cost { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
        public Nullable<int> Age { get; set; }
        public string Eduacation { get; set; }
        public string Profession { get; set; }
    
        public virtual EventType EventType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venue> Venue { get; set; }
    }
}
