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
    public class ProgramTests
    {
        [TestMethod()]
        public void testWhenQuestionResultEqualAnswer_addPointShouldReturn1()
        {
            QuestionData questionData = new QuestionData("question", "1", "2", "3", 3);
            Program program = new Program();

            Assert.AreEqual(program.addPoint(3, questionData), 1);
        }

        [TestMethod()]
        public void testWhenQuestionResultDoesNotEqualAnswer_addPointShouldReturn0()
        {
            QuestionData questionData = new QuestionData("question", "1", "2", "3", 3);
            Program program = new Program();

            Assert.AreEqual(program.addPoint(2, questionData), 0);
        }
    }
}