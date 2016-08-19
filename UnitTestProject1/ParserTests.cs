using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tests
{
    [TestClass()]
    public class ParserTests
    {
        [TestMethod()]
        public void testWhenInputStringEqual3_tryToParseShouldReturn3()
        {
            Parser parser = new Parser();

            Assert.AreEqual(parser.tryToParseValueFrom1To3("3"),3);
        }

        [TestMethod()]
        public void testWhenInputStringConsistOfCharacters_tryToParseShouldReturn0()
        {
            Parser parser = new Parser();

            Assert.AreEqual(parser.tryToParseValueFrom1To3("Foo Bar"), 0);
        }

        [TestMethod()]
        public void testWhenInputStringMore3_tryToParseShouldReturn0()
        {
            Parser parser = new Parser();

            Assert.AreEqual(parser.tryToParseValueFrom1To3("5"), 0);
        }

        [TestMethod()]
        public void testWhenInputStringLess1_tryToParseShouldReturn0()
        {
            Parser parser = new Parser();

            Assert.AreEqual(parser.tryToParseValueFrom1To3("0"), 0);
        }
    }
}