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
    // logger_thread_statuses
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.15.2.0")]
    public class LoggerThreadStatus
    {
        public int Id { get; set; } // id (Primary key)
        public string Code { get; set; } // code
        public string Name { get; set; } // name

        // Reverse navigation
        public virtual ICollection<LoggerThread> LoggerThreads { get; set; } // logger_threads.FK_dbo.logger_threads_dbo.logger_thread_statuses_log_status_id
        
        public LoggerThreadStatus()
        {
            LoggerThreads = new List<LoggerThread>();
        }
    }

}
