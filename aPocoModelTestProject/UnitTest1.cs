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
        public void TestMethod1()
        {
            System.Data.Entity.Database.SetInitializer(new PocoLagaInitializer());

            using (var context = new LagaModelDbContext())
            {
                var threadList = context.LoggerThreads.ToList();
                Assert.AreEqual(threadList.Count, 1);
            }
            
        }
    }
}
