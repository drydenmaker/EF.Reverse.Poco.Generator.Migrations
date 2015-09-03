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
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.15.1.0")]
    public class FakeLagaModelDbContext : ILagaModelDbContext
    {
        public DbSet<LoggerEntry> LoggerEntries { get; set; }
        public DbSet<LoggerOperation> LoggerOperations { get; set; }
        public DbSet<LoggerThread> LoggerThreads { get; set; }
        public DbSet<LoggerThreadStatus> LoggerThreadStatus { get; set; }

        public FakeLagaModelDbContext()
        {
            LoggerEntries = new FakeDbSet<LoggerEntry>();
            LoggerOperations = new FakeDbSet<LoggerOperation>();
            LoggerThreads = new FakeDbSet<LoggerThread>();
            LoggerThreadStatus = new FakeDbSet<LoggerThreadStatus>();
        }
        
        public int SaveChangesCount { get; private set; } 
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        
        // Stored Procedures
    }
}
