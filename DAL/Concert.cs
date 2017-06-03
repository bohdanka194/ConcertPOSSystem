namespace DAL
{
    // all usings outside of namespace!
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Concert")]
    public partial class Concert
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Concert()
        {
            Ticket = new HashSet<Ticket>();
        }

        //name should be Id
        // and in other cases too
        public Guid ID { get; set; }

        public Guid OrganizerID { get; set; }

        public Guid PlaceID { get; set; }

        public DateTime Time { get; set; }

        public virtual Organizer Organizer { get; set; }

        public virtual Place Place { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
