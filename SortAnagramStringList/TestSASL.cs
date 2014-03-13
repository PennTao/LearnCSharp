using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace SortAnagramStringList
{
    [TestFixture]
    class TestSASL
    {
        [Test]
        public void TestSort()
        {
            List<string> list1 = new List<string>();
            List<string> test = new List<string>();
            List<string> res;
            res = SortAnagramStringList.Program.SortAnaStrList(list1);
            Assert.AreEqual(test, res);

            list1.Add("abc");
            test.Add("abc");

            res = SortAnagramStringList.Program.SortAnaStrList(list1);
            Assert.AreEqual(test, res);
            
            list1.Add("cba");
            list1.Add("bba");
            list1.Add("bca");


            test.Add("cba");
            test.Add("bca");
            test.Add("bba");

            res = SortAnagramStringList.Program.SortAnaStrList(list1);
            Assert.AreEqual(test, res);

            list1.Add("ffff");
            test.Add("ffff");
            res = SortAnagramStringList.Program.SortAnaStrList(list1);
            Assert.AreEqual(test, res);
        }
    }
}
