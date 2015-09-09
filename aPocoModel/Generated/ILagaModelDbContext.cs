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
    public interface ILagaModelDbContext : IDisposable
    {
        DbSet<LoggerEntry> LoggerEntries { get; set; } // logger_entries
        DbSet<LoggerOperation> LoggerOperations { get; set; } // logger_operations
        DbSet<LoggerThread> LoggerThreads { get; set; } // logger_threads
        DbSet<LoggerThreadStatus> LoggerThreadStatus { get; set; } // logger_thread_statuses

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        // Stored Procedures
    }

}
