namespace amodel.Generated
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LagaModel : DbContext
    {
        public LagaModel()
            : base("name=LagaModel")
        {
        }

        public virtual DbSet<logger_entries> logger_entries { get; set; }
        public virtual DbSet<logger_operations> logger_operations { get; set; }
        public virtual DbSet<logger_thread_statuses> logger_thread_statuses { get; set; }
        public virtual DbSet<logger_threads> logger_threads { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<logger_entries>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<logger_operations>()
                .HasMany(e => e.logger_entries)
                .WithRequired(e => e.logger_operations)
                .HasForeignKey(e => e.logger_operation_id);

            modelBuilder.Entity<logger_thread_statuses>()
                .HasMany(e => e.logger_threads)
                .WithOptional(e => e.logger_thread_statuses)
                .HasForeignKey(e => e.log_status_id);

            modelBuilder.Entity<logger_threads>()
                .HasMany(e => e.logger_operations)
                .WithOptional(e => e.logger_threads)
                .HasForeignKey(e => e.logger_thread_id);
        }
    }

    public class LagaInitializer : DropCreateDatabaseAlways<LagaModel>
    {
        #region Overrides of DropCreateDatabaseAlways<LagaModel>

        /// <summary>
        /// A method that should be overridden to actually add data to the context for seeding.
        ///             The default implementation does nothing.
        /// </summary>
        /// <param name="context">The context to seed. </param>
        protected override void Seed(LagaModel context)
        {
            var thread = new logger_threads()
            {
                title = "TEST TITLE",
                guid = Guid.NewGuid().ToString(),

            };

            context.logger_threads.Add(thread);

            base.Seed(context);
        }

        #endregion
    }
}
