namespace FunctionsTest
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Functions;

    [TestClass]
    public class FunctionsTest
    {
        [TestInitialize]
        public void Initialize()
        {
            list = new List<Int32> {1, 2, 3};
        }

        [TestMethod]
        public void MapTest()
        {
            List<Int32> result = Functions<Int32>.Map(list, x => x * x);
            Assert.IsTrue(result[0] == 1 && result[1] == 4 && result[2] == 9);

        }

        [TestMethod]
        public void FilterTest()
        {
            List<Int32> result = Functions<Int32>.Filter(list, x => x == 1);
            Assert.AreEqual(result[0], 1);
        }

        [TestMethod]
        public void FoldTest()
        {
            Assert.AreEqual(Functions<Int32>.Fold(list, 1, (x, number) => x + number), 7);
        }

        private List<Int32> list;
    }
}
