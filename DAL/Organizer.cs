namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Organizer")]
    public partial class Organizer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organizer()
        {
            Concert = new HashSet<Concert>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(60)]
        public string Login { get; set; }

        [Required]
        [StringLength(40)]
        public string OrganizerName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Concert> Concert { get; set; }
    }
}
