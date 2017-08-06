using BashSoft;
using BashSoft.DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoftTesting
{
    [TestFixture]
    public class OrderedDataStructureTester
    {
        private ISimpleOrderedBag<string> names;

        [SetUp]
        public void SetUp()
        {
            this.names = new SimpleSortedList<string>();
        }

        [Test]
        public void TestEmptyCtor()
        {
            this.names = new SimpleSortedList<string>();

            Assert.AreEqual(this.names.Capacity, 16);
            Assert.AreEqual(this.names.Size, 0);
        }

        [Test]
        public void TestCtorWithInitialCapacity()
        {
            this.names = new SimpleSortedList<string>(20);

            Assert.AreEqual(this.names.Capacity, 20);
            Assert.AreEqual(this.names.Size, 0);
        }

        [Test]
        public void TestCtorWithAllParams()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase, 30);

            Assert.AreEqual(this.names.Capacity, 30);
            Assert.AreEqual(this.names.Size, 0);
        }

        [Test]
        public void TestCtorWithInitialComparer()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);

            Assert.AreEqual(this.names.Capacity, 16);
            Assert.AreEqual(this.names.Size, 0);
        }

        [Test]
        public void TestAddIncreasesSize()
        {
            this.names.Add("Nasko");

            Assert.AreEqual(1, this.names.Size);
        }

        [Test]
        public void TestAddNullThrowsException()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => this.names.Add(null));

            Assert.That(ex.Message, Is.EqualTo("Value cannot be null."));
        }

        [Test]
        public void TestAddUnsortedDataIsHeldSorted()
        {
            this.names.Add("Rosen");                    
            this.names.Add("Balkan");
            this.names.Add("Georgi");

            Assert.AreEqual("Balkan", names.First());
            Assert.AreEqual("Rosen", names.Last());
        }

        [Test]
        public void TestAddingMoreThanInitialCapacity()
        {
            for (int i = 0; i < 17; i++)
            {
                this.names.Add("Test");
            }           

            Assert.AreEqual(17, this.names.Size);
            Assert.AreNotEqual(16, this.names.Capacity);
        }

        [Test]
        public void TestAddingAllFromCollectionIncreasesSize()
        {
            List<string> test = new List<string>() { "test", "test" };
            this.names.AddAll(test);

            Assert.AreEqual(2, this.names.Size);           
        }

        [Test]
        public void TestAddingAllFromNullThrowsException()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => this.names.AddAll(null));

            Assert.That(ex.Message, Is.EqualTo("Value cannot be null."));
        }

        [Test]
        public void TestAddAllKeepsSorted()
        {           
            ICollection<string> test = new List<string>() { "aaa", "abc", "bcd" };
            this.names.AddAll(test);

            Assert.AreEqual("aaa", names.First());
            Assert.AreEqual("bcd", names.Last());
        }

        [Test]
        public void TestRemoveValidElementDecreasesSize()
        {           
            this.names.Add("test");
            this.names.Remove("name");

            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestRemoveValidElementRemovesSelectedOne()
        {
            this.names.Add("ivan");
            this.names.Add("nasko");
            this.names.Remove("ivan");

            Assert.AreNotEqual("ivan", this.names.First());
        }

        [Test]
        public void TestRemovingNullThrowsException()
        {                        
            var ex = Assert.Throws<ArgumentNullException>(() => this.names.Remove(null));

            Assert.That(ex.Message, Is.EqualTo("Value cannot be null."));
        }

        [Test]
        public void TestJoinWithNull()
        {
            this.names.Add("ivan");
            this.names.Add("nasko");            

            var ex = Assert.Throws<ArgumentNullException>(() => this.names.JoinWith(null));

            Assert.That(ex.Message, Is.EqualTo("Value cannot be null."));
        }

        [Test]
        public void TestJoinWorksFine()
        {
            this.names.Add("ivan");
            this.names.Add("nasko");
            

            Assert.AreEqual("ivan, nasko", this.names.JoinWith(", "));
        }
    }
}
