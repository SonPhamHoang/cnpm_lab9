using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Student s;
        private StudentService ss;

        [TestInitialize]
        public void init()
        {
            s = new Student();
            ss = new StudentService();
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void exceptionShouldThrow()
        {
            double score = 12;
            Assert.IsFalse(score, "Not in range [0,10]");
        }


        [TestMethod]

        public void TestScore_9()
        { 
            s.Score = 9;

            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void TestScore_7()
        {
            s.Score = 7;

            char letter = s.getLetterScore();

            Assert.AreEqual('B', letter);
        }

        

        [TestMethod]
        public void TestScore_5()
        {
            s.Score = 5;

            char letter = s.getLetterScore();

            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void TestScore_35()
        {
            s.Score = 3.5;

            char letter = s.getLetterScore();

            Assert.AreEqual('D', letter);
        }
        [TestMethod]
        public void TestScore_1()
        {
            s.Score = 1;
            char letter = s.getLetterScore();

            Assert.AreEqual('E', letter);
        }

        [TestMethod]
        [DataRow(9,'A')]
        [DataRow(7,'B')]
        [DataRow(5,'C')]
        [DataRow(4,'D')]
        [DataRow(1,'E')]
        public void TestScore(int score, char expect)
        {
            s.Score = score;
            char letter = s.getLetterScore();
            Assert.AreEqual(letter, expect);

        }

        [TestMethod]
        public void TestAddStudent()
        {
            Student s1 = new Student();
            ss.addStudent(s1);
            Assert.IsFalse(s1.Id,);
        }
    }
}