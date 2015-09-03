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
    // logger_operations
    internal class LoggerOperationConfiguration : EntityTypeConfiguration<LoggerOperation>
    {
        public LoggerOperationConfiguration()
            : this("dbo")
        {
        }
 
        public LoggerOperationConfiguration(string schema)
        {
            ToTable(schema + ".logger_operations");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName("title").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.LoggerThreadId).HasColumnName("logger_thread_id").IsOptional().HasColumnType("int");
            Property(x => x.Description).HasColumnName("description").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Created).HasColumnName("created").IsOptional().HasColumnType("datetime");

            // Foreign keys
            HasOptional(a => a.LoggerThread).WithMany(b => b.LoggerOperations).HasForeignKey(c => c.LoggerThreadId); // FK_dbo.logger_operations_dbo.logger_threads_logger_thread_id
        }
    }

}
