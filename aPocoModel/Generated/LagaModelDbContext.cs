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
    public class LagaModelDbContext : DbContext, ILagaModelDbContext
    {
        public DbSet<LoggerEntry> LoggerEntries { get; set; } // logger_entries
        public DbSet<LoggerOperation> LoggerOperations { get; set; } // logger_operations
        public DbSet<LoggerThread> LoggerThreads { get; set; } // logger_threads
        public DbSet<LoggerThreadStatus> LoggerThreadStatus { get; set; } // logger_thread_statuses
        
        static LagaModelDbContext()
        {
            System.Data.Entity.Database.SetInitializer(new PocoLagaUpgradeInitializer<LagaModelDbContext>());
        }

        public LagaModelDbContext()
            : base("Name=LagaModel")
        {
        }

        public LagaModelDbContext(string connectionString) : base(connectionString)
        {
        }

        public LagaModelDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == DBNull.Value);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new LoggerEntryConfiguration());
            modelBuilder.Configurations.Add(new LoggerOperationConfiguration());
            modelBuilder.Configurations.Add(new LoggerThreadConfiguration());
            modelBuilder.Configurations.Add(new LoggerThreadStatusConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new LoggerEntryConfiguration(schema));
            modelBuilder.Configurations.Add(new LoggerOperationConfiguration(schema));
            modelBuilder.Configurations.Add(new LoggerThreadConfiguration(schema));
            modelBuilder.Configurations.Add(new LoggerThreadStatusConfiguration(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
    }
}
