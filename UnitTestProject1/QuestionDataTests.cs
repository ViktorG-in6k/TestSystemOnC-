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
    public class QuestionDataTests
    {
        [TestMethod()]
        public void testToStringShouldReturnExpectedString()
        {
            QuestionData questionData = new QuestionData("question", "1", "2", "3", 4);
            string expected = "question\n1) 1\n2) 2\n3) 3\n";

            Assert.AreEqual(questionData.ToString(), expected);
        }
    }
}