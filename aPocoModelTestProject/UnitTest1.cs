using System;
using System.Linq;
using aPocoModel.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace aPocoModelTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
        }
        [TestMethod]
        public void TestPocoMethod()
        {
            (new LagaModelDbContext()).Dispose();
            System.Data.Entity.Database.SetInitializer(new PocoLagaInitializer<LagaModelDbContext>());

            using (var context = new LagaModelDbContext())
            {
                var threadList = context.LoggerThreads.ToList();
                Assert.AreEqual(1, threadList.Count);
            }
            
        }
    }
}
