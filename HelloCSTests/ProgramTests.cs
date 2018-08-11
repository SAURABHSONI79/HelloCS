using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCS.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void StringTest()
        {
            string str = "abcd";
            Assert.AreEqual("dcba", Program.StringTest(str));

        }

        [TestMethod()]
        public void ThisWillFail()
        {
            Assert.AreEqual(0, 1);
        }

        [TestMethod()]
        public void ThisWillPass()
        {
            Assert.AreEqual(1, 1);
        }

       
    }
}