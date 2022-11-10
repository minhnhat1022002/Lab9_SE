
using StudentServiceLib;

namespace TestLab9
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Score3p5_Should_D()
        {
            var a = new Student();
            a.Score = 3.5;
            char letter = a.getLetterScore();
            Assert.AreEqual('D', letter);
        }
        [TestMethod]
        public void Score5_Should_C()
        {
            var a = new Student();
            a.Score = 5;
            char letter = a.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void Score7_Should_B()
        {
            var a = new Student();
            a.Score = 7;
            char letter = a.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void Score8_Should_A()
        {
            var a = new Student();
            a.Score = 8;
            char letter = a.getLetterScore();
            Assert.AreEqual('A', letter);
        }
    }
}