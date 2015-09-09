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
    public class LoggerThreadStatusConfiguration : EntityTypeConfiguration<LoggerThreadStatus>
    {
        public LoggerThreadStatusConfiguration()
            : this("dbo")
        {
        }
 
        public LoggerThreadStatusConfiguration(string schema)
        {
            ToTable(schema + ".logger_thread_statuses");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName("code").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.Name).HasColumnName("name").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
        }
    }

}
