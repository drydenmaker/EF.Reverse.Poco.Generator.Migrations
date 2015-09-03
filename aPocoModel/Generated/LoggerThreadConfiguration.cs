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
    // logger_threads
    internal class LoggerThreadConfiguration : EntityTypeConfiguration<LoggerThread>
    {
        public LoggerThreadConfiguration()
            : this("dbo")
        {
        }
 
        public LoggerThreadConfiguration(string schema)
        {
            ToTable(schema + ".logger_threads");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName("title").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.LogStatusId).HasColumnName("log_status_id").IsOptional().HasColumnType("int");
            Property(x => x.ParentId).HasColumnName("parent_id").IsOptional().HasColumnType("int");
            Property(x => x.Guid).HasColumnName("guid").IsRequired().HasColumnType("nvarchar").HasMaxLength(120);
            Property(x => x.Created).HasColumnName("created").IsOptional().HasColumnType("datetime");
            Property(x => x.Updated).HasColumnName("updated").IsOptional().HasColumnType("datetime");

            // Foreign keys
            HasOptional(a => a.LoggerThreadStatus).WithMany(b => b.LoggerThreads).HasForeignKey(c => c.LogStatusId); // FK_dbo.logger_threads_dbo.logger_thread_statuses_log_status_id
        }
    }

}
