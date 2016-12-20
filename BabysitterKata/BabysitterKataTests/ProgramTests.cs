﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabysitterKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void VerifyValidStartTimeTest()
        {
            BabysittingJob babysittingJob = new BabysittingJob();
            babysittingJob.StartTime = 1700;

            Assert.IsTrue(babysittingJob.IsValidStartTime);
        }
    }
}