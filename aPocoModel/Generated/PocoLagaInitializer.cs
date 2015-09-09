namespace aPocoModel.Generated
{
    public class PocoLagaInitializer<T> : System.Data.Entity.DropCreateDatabaseAlways<LagaModelDbContext>
    {
        #region Overrides of DropCreateDatabaseAlways<LagaModel>

        /// <summary>
        /// A method that should be overridden to actually add data to the context for seeding.
        ///             The default implementation does nothing.
        /// </summary>
        /// <param name="context">The context to seed. </param>
        protected override void Seed(LagaModelDbContext context)
        {
            var thread = new Generated.LoggerThread()
            {
                Title = "TEST TITLE",
                Guid = System.Guid.NewGuid().ToString(),

            };

            context.LoggerThreads.Add(thread);

            base.Seed(context);
        }

        #endregion
    }
}