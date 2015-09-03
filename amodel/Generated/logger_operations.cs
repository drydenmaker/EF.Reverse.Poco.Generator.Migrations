namespace amodel.Generated
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logger_operations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public logger_operations()
        {
            logger_entries = new HashSet<logger_entries>();
        }

        public int id { get; set; }

        [StringLength(150)]
        public string title { get; set; }

        public int? logger_thread_id { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        public DateTime? created { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<logger_entries> logger_entries { get; set; }

        public virtual logger_threads logger_threads { get; set; }
    }
}
