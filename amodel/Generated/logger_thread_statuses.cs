namespace amodel.Generated
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logger_thread_statuses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public logger_thread_statuses()
        {
            logger_threads = new HashSet<logger_threads>();
        }

        public int id { get; set; }

        [StringLength(150)]
        public string code { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<logger_threads> logger_threads { get; set; }
    }
}
