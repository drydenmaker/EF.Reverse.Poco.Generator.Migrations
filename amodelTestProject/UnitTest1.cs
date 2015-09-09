using System;
using System.Linq;
using amodel.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace amodelTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
        }
        [TestMethod]
        public void TestEf6DesignerMethod()
        {
            System.Data.Entity.Database.SetInitializer(new LagaInitializer());

            using (var context = new LagaModel())
            {
                var threadList = context.logger_threads.ToList();
                Assert.AreEqual(threadList.Count, 1);
            }
            
        }
    }
}
