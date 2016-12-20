﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata.Tests
{
    [TestClass()]
    public class BedTimeTests
    {
        BabysittingJob babysittingJob = new BabysittingJob();

        [TestMethod()]
        public void VerifySettingBedTimeTest()
        {
            babysittingJob.BedTime = 2300;
            Assert.AreEqual(2300, babysittingJob.BedTime);
        }
    }
}