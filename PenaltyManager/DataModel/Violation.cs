namespace PenaltyManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Violation")]
    public partial class Violation
    {
        public int Automobile_id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Driver_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public virtual Automobile Automobile { get; set; }

        public virtual Driver Driver { get; set; }

        public virtual ViolationType ViolationType { get; set; }
    }
}
