namespace Set.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SetNamespace;

    [TestClass]
    public class SetTest
    {
        [TestInitialize]
        public void Initialize()
        {
            setInt1 = new Set<int>();
            setInt2 = new Set<int>();
        }

        [TestMethod]
        public void isEmptyIntTest()
        {
            Assert.IsTrue(setInt1.isEmpty());
        }

        [TestMethod]
        public void AddTest()
        {
            setInt1.Add(1);
            Assert.IsFalse(setInt1.isEmpty());
        }

        [TestMethod]
        public void DeleteTest()
        {
            setInt1.Add(1);
            setInt1.Delete(1);
            Assert.IsTrue(setInt1.isEmpty());
        }

        [TestMethod]
        public void SearchElementTest()
        {
            setInt1.Add(1);
            Assert.IsTrue(setInt1.SearchElement(1));
        }

        [TestMethod]
        public void IntersectionTest()
        {
            setInt1.Add(1);
            setInt1.Add(0);
            setInt1.Add(2);
            setInt1.Add(7);

            setInt2.Add(1);
            setInt2.Add(0);
            setInt2.Add(2);

            setInt1.Intersection(setInt2);

            Assert.IsTrue(setInt2.isEmpty());
        }

        [TestMethod]
        public void UnionTest()
        {
            setInt1.Add(1);
            
            setInt1.Union(setInt2);

            Assert.IsFalse(setInt2.isEmpty());
        }

        Set<int> setInt1;
        Set<int> setInt2;
    }
}
