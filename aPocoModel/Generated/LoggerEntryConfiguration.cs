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
    internal class LoggerEntryConfiguration : EntityTypeConfiguration<LoggerEntry>
    {
        public LoggerEntryConfiguration()
            : this("dbo")
        {
        }
 
        public LoggerEntryConfiguration(string schema)
        {
            ToTable(schema + ".logger_entries");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.LoggerOperationId).HasColumnName("logger_operation_id").IsRequired().HasColumnType("int");
            Property(x => x.EventId).HasColumnName("event_id").IsOptional().HasColumnType("int");
            Property(x => x.Priority).HasColumnName("priority").IsOptional().HasColumnType("int");
            Property(x => x.Severity).HasColumnName("severity").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Title).HasColumnName("title").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.Message).HasColumnName("message").IsRequired().IsUnicode(false).HasColumnType("text").HasMaxLength(2147483647);
            Property(x => x.Timestamp).HasColumnName("timestamp").IsRequired().HasColumnType("datetime");
            Property(x => x.MachineName).HasColumnName("machine_name").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.ProcessId).HasColumnName("process_id").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.ProcessName).HasColumnName("process_name").IsOptional().HasColumnType("nvarchar").HasMaxLength(512);
            Property(x => x.ThreadName).HasColumnName("thread_name").IsOptional().HasColumnType("nvarchar").HasMaxLength(512);
            Property(x => x.Win32Thread).HasColumnName("win32_thread").IsOptional().HasColumnType("nvarchar").HasMaxLength(128);

            // Foreign keys
            HasRequired(a => a.LoggerOperation).WithMany(b => b.LoggerEntries).HasForeignKey(c => c.LoggerOperationId); // FK_dbo.logger_entries_dbo.logger_operations_logger_operation_id
        }
    }

}
