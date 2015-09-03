namespace amodel.Generated
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logger_entries
    {
        public int id { get; set; }

        public int logger_operation_id { get; set; }

        public int? event_id { get; set; }

        public int? priority { get; set; }

        [StringLength(50)]
        public string severity { get; set; }

        [StringLength(250)]
        public string title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string message { get; set; }

        public DateTime timestamp { get; set; }

        [StringLength(250)]
        public string machine_name { get; set; }

        [StringLength(255)]
        public string process_id { get; set; }

        [StringLength(512)]
        public string process_name { get; set; }

        [StringLength(512)]
        public string thread_name { get; set; }

        [StringLength(128)]
        public string win32_thread { get; set; }

        public virtual logger_operations logger_operations { get; set; }
    }
}
