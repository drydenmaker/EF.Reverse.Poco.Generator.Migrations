// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace aPocoModel.Generated
{
    // logger_entries
    public class LoggerEntry
    {
        public int Id { get; set; } // id (Primary key)
        public int LoggerOperationId { get; set; } // logger_operation_id
        public int? EventId { get; set; } // event_id
        public int? Priority { get; set; } // priority
        public string Severity { get; set; } // severity
        public string Title { get; set; } // title
        public string Message { get; set; } // message
        public DateTime Timestamp { get; set; } // timestamp
        public string MachineName { get; set; } // machine_name
        public string ProcessId { get; set; } // process_id
        public string ProcessName { get; set; } // process_name
        public string ThreadName { get; set; } // thread_name
        public string Win32Thread { get; set; } // win32_thread

        // Foreign keys
        public virtual LoggerOperation LoggerOperation { get; set; } // FK_dbo.logger_entries_dbo.logger_operations_logger_operation_id
    }

}
