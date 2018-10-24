//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flats
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flats()
        {
            this.Bookings = new HashSet<Bookings>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int Number { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Rooms { get; set; }
        public Nullable<int> Size { get; set; }
        public Nullable<int> Floor { get; set; }
        public Nullable<bool> Available { get; set; }
        public Nullable<bool> Booked { get; set; }
        public Nullable<bool> Sold { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bookings> Bookings { get; set; }
    }
}