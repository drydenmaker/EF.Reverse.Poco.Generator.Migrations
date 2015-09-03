namespace amodel.Generated
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logger_threads
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public logger_threads()
        {
            logger_operations = new HashSet<logger_operations>();
        }

        public int id { get; set; }

        [StringLength(250)]
        public string title { get; set; }

        public int? log_status_id { get; set; }

        public int? parent_id { get; set; }

        [Required]
        [StringLength(120)]
        public string guid { get; set; }

        public DateTime? created { get; set; }

        public DateTime? updated { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<logger_operations> logger_operations { get; set; }

        public virtual logger_thread_statuses logger_thread_statuses { get; set; }
    }
}
