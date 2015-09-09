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
using System.Data.Entity.Migrations;

namespace aPocoModel.Generated
{
    // logger_operations
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.15.2.0")]
    public class LoggerOperation
    {
        public int Id { get; set; } // id (Primary key)
        public string Title { get; set; } // title
        public int? LoggerThreadId { get; set; } // logger_thread_id
        public string Description { get; set; } // description
        public DateTime? Created { get; set; } // created

        // Reverse navigation
        public virtual ICollection<LoggerEntry> LoggerEntries { get; set; } // logger_entries.FK_dbo.logger_entries_dbo.logger_operations_logger_operation_id

        // Foreign keys
        public virtual LoggerThread LoggerThread { get; set; } // FK_dbo.logger_operations_dbo.logger_threads_logger_thread_id
        
        public LoggerOperation()
        {
            LoggerEntries = new List<LoggerEntry>();
        }
    }

}
