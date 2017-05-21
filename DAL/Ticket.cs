namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        public Guid ID { get; set; }

        public Guid ConcertID { get; set; }

        public Guid? UserID { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int Row { get; set; }

        public int Seat { get; set; }

        public virtual Concert Concert { get; set; }

        public virtual User User { get; set; }
    }
}
