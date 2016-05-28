using Microsoft.VisualStudio.TestTools.UnitTesting;
using Timer;

namespace TimerTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests how best and words times are changed in a session
        /// </summary>
        [TestMethod]
        public void TestBestAndWorstTimes()
        {
            Session session = new Session();

            //Add first solve
            Solve solve1 = new Solve();
            solve1.Time = 2.0f;
            session.Add(solve1);
            Assert.AreEqual(solve1.Time, session.WorstTime);
            Assert.AreEqual(solve1.Time, session.BestTime);

            //Add second sovle
            Solve solve2 = new Solve();
            solve2.Time = 1.0f;
            session.Add(solve2);
            Assert.AreEqual(solve1.Time, session.WorstTime);
            Assert.AreEqual(solve2.Time, session.BestTime);

            //Remove first solve
            session.Remove(0);
            Assert.AreEqual(solve2.Time, session.WorstTime);
            Assert.AreEqual(solve2.Time, session.BestTime);
        }

        /// <summary>
        /// Tests how best and words times are changed in a session when they are marked as DNF
        /// </summary>
        [TestMethod]
        public void TestDnfBestAndWorstTimes()
        {
            Session session = new Session();
            
            //Add first
            Solve solve1 = new Solve();
            solve1.Time = 2.0f;
            solve1.penalty = "DNF";
            session.Add(solve1);            
            Assert.AreEqual(float.MinValue, session.WorstTime);
            Assert.AreEqual(float.MaxValue, session.BestTime);

            //Add second sovle
            Solve solve2 = new Solve();
            solve2.Time = 1.0f;
            session.Add(solve2);
            Assert.AreEqual(solve2.Time, session.WorstTime);
            Assert.AreEqual(solve2.Time, session.BestTime);

            solve1.penalty = "";
            session.RecalculateBestAndWorstTimes();
            Assert.AreEqual(solve1.Time, session.WorstTime);
            Assert.AreEqual(solve2.Time, session.BestTime);

        }
    }
}
