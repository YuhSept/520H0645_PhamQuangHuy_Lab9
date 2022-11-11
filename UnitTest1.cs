using StudentServiceLib;
using Xunit.Sdk;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student s = new Student();
            s.Score = 8.5;
            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Student s = new Student();
            s.Score = 8.0;
            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Student s = new Student();
            s.Score = 7.5;
            char letter = s.getLetterScore();

            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Student s = new Student();
            s.Score = 7.0;
            char letter = s.getLetterScore();

            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Student s = new Student();
            s.Score = 5.0;
            char letter = s.getLetterScore();

            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Student s = new Student();
            s.Score = 2.0;
            char letter = s.getLetterScore();

            Assert.AreEqual('E', letter);
        }
    }
}