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
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<int> SoldTicketsCount { get; set; }
        public Nullable<int> GainTicketsCount { get; set; }
        public Nullable<int> Cost { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
        public Nullable<int> Age { get; set; }
        public string Eduacation { get; set; }
        public string Profession { get; set; }
        public Nullable<int> VenueId { get; set; }
    
        public virtual EventType EventType { get; set; }
        public virtual Venue Venue { get; set; }
    }
}
