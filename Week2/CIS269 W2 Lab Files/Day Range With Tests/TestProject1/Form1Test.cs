using _42dayrange;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq; // *************** I ADDED THIS ***************

namespace TestProject1
{


    /// <summary>
    ///This is a test class for Form1Test and is intended
    ///to contain all Form1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Form1Test
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion



        // What does it mean for two
        // IEnumerable to be equal?
        //  a == b ??? NO!
        // 1. Same elements
        // 2. Same order
        bool IsEnumerableEqual(IEnumerable<Day> a,
            IEnumerable<Day> b)
        {
            if (a.Count() != b.Count())
                return false;

            for (int i = 0; i < a.Count(); i++)
            {
                if (a.ElementAt(i) != b.ElementAt(i))
                    return false;
            }
            return true;

        }

        [TestMethod()]
        [DeploymentItem("242dayrange.exe")]
        public void EmptyCheckboxDaysTest()
        {
            Form1 target = new Form1();
            IEnumerable<Day> expected = null;
            IEnumerable<Day> actual;

            // by default, none of the checkboxes are checked
            actual = target.GetCheckboxDays();
            // then "actual" should be "empty list"
            expected = new Day[0];

            //  v  notice the ! means not
            if (!IsEnumerableEqual(actual, expected))
                Assert.Fail();


        }


        [TestMethod()]
        [DeploymentItem("242dayrange.exe")]
        public void SparseCheckboxDaysTest()
        {
            Form1 target = new Form1();
            IEnumerable<Day> expected = null;
            IEnumerable<Day> actual;

            target.chkThursday.Checked = true;
            target.chkSunday.Checked = true;
            target.chkFriday.Checked = true;
            actual = target.GetCheckboxDays();
            // expected = new Day[3] { Day.Sunday, Day.Thursday, Day.Friday}; // WRONG
            expected = new Day[3] { Day.Thursday, Day.Friday, Day.Sunday };
            //  v  notice the ! means not
            if (!IsEnumerableEqual(actual, expected))
                Assert.Fail();


            target.chkThursday.Checked = false;
            target.chkSunday.Checked = true;
            target.chkFriday.Checked = false;
            actual = target.GetCheckboxDays();
            expected = new Day[1] { Day.Sunday };

            //  v  notice the ! means not
            if (!IsEnumerableEqual(actual, expected))
                Assert.Fail();
        }

        [TestMethod()]
        [DeploymentItem("242dayrange.exe")]
        public void AllCheckboxDaysTest()
        {
            Form1 target = new Form1();
            IEnumerable<Day> expected = null;
            IEnumerable<Day> actual;

            // actual = target.GetCheckboxDays(); // WRONG!

            target.chkSaturday.Checked = true;
            target.chkMonday.Checked = true;
            target.chkTuesday.Checked = true;
            target.chkWednesday.Checked = true;
            target.chkSunday.Checked = true;
            target.chkThursday.Checked = true;
            target.chkFriday.Checked = true;

            actual = target.GetCheckboxDays(); // CORRECTED

            /*   WRONG!!!
            expected = new Day[7] { Day.Sunday, Day.Monday,
                Day.Tuesday, Day.Wednesday, Day.Thursday,
                Day.Friday, Day.Saturday };
                */

            // CORECTED
            expected = new Day[7] { Day.Monday,
        Day.Tuesday, Day.Wednesday, Day.Thursday,
        Day.Friday, Day.Saturday, Day.Sunday };


            if (!IsEnumerableEqual(actual, expected))
                Assert.Fail();


        }
        [TestMethod()]
        [DeploymentItem("242dayrange.exe")]
        public void MonThuTest()
        {
            Form1 target = new Form1();
            IEnumerable<Day> expected = null;
            IEnumerable<Day> actual;

            // Monday and Thursday
            target.chkThursday.Checked = true;
            target.chkMonday.Checked = true;
            actual = target.GetCheckboxDays();
            // then "actual" should be mon, thu
            expected = new Day[2] { Day.Monday, Day.Thursday };

            //  v  notice the ! means not
            if (!IsEnumerableEqual(actual, expected))
                Assert.Fail();


        }

        /// <summary>
        ///A test for ToDayRange
        ///</summary>
        [TestMethod()]
        [DeploymentItem("242dayrange.exe")]
        public void ToDayRangeTest()
        {
            Form1 target = new Form1();
            Day[] days;
            string actual;

            days = new Day[1] { Day.Monday };
            actual = target.ToDayRange(days);
            Assert.AreEqual("Monday", actual, "message");

            days = new Day[1] { Day.Saturday };
            actual = target.ToDayRange(days);
            Assert.AreEqual("Saturday", actual);

            days = new Day[0];
            actual = target.ToDayRange(days);
            Assert.AreEqual("", actual);
        }

        [TestMethod()]
        [DeploymentItem("242dayrange.exe")]
        public void ToDayRangeTest2()
        {
            Form1 target = new Form1();
            Day[] days;
            string actual;


            days = new Day[] {
                 Day.Tuesday, Day.Wednesday,
                Day.Thursday };
            actual = target.ToDayRange(days);
            Assert.AreEqual("Tuesday-Thursday", actual);


            days = new Day[] {
                 Day.Monday, Day.Tuesday,
                Day.Thursday, Day.Friday, Day.Saturday, Day.Sunday };
            actual = target.ToDayRange(days);
            Assert.AreEqual("Monday, Tuesday, Thursday-Sunday", actual);

            days = new Day[] {
                Day.Monday, Day.Tuesday, Day.Wednesday,
                Day.Thursday, Day.Friday, Day.Saturday };
            actual = target.ToDayRange(days);
            Assert.AreEqual("Monday-Saturday", actual);

            days = new Day[] {
                Day.Monday, Day.Tuesday, Day.Wednesday,
                Day.Thursday, Day.Friday, Day.Saturday, Day.Sunday };
            actual = target.ToDayRange(days);
            Assert.AreEqual("Monday-Sunday", actual);

            days = new Day[] {
                Day.Monday, Day.Tuesday, Day.Wednesday,
                Day.Thursday,  Day.Sunday };
            actual = target.ToDayRange(days);
            Assert.AreEqual("Monday-Thursday, Sunday", actual);

        }


        [TestMethod()]
        [DeploymentItem("242dayrange.exe")]
        public void ToDayRangeTestBothKinds()
        {
            Form1 target = new Form1();
            Day[] days;
            string actual;

            days = new Day[] { Day.Monday, Day.Tuesday,
                Day.Wednesday, Day.Friday };
            actual = target.ToDayRange(days);
            Assert.AreEqual("Monday-Wednesday, Friday", actual);

            days = new Day[] {
                 Day.Monday, Day.Tuesday,
                Day.Thursday,  Day.Saturday, Day.Sunday };
            actual = target.ToDayRange(days);
            Assert.AreEqual("Monday, Tuesday, Thursday, Saturday, Sunday", actual);

            days = new Day[] {
                 Day.Tuesday, Day.Wednesday,
                Day.Thursday, Day.Saturday, Day.Sunday };
            actual = target.ToDayRange(days);
            Assert.AreEqual("Tuesday-Thursday, Saturday, Sunday", actual);


            days = new Day[] {
                Day.Monday, Day.Tuesday, Day.Wednesday,
                Day.Thursday, Day.Saturday, Day.Sunday };
            actual = target.ToDayRange(days);
            Assert.AreEqual("Monday-Thursday, Saturday, Sunday", actual);


            days = new Day[] {
                Day.Monday, Day.Tuesday, Day.Wednesday,
                Day.Friday, Day.Saturday, Day.Sunday };
            actual = target.ToDayRange(days);
            Assert.AreEqual("Monday-Wednesday, Friday-Sunday", actual);


        }
    }
}
