using System;
using BusinessLogic;
using BusinessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DateManipulation.Tests
{
    [TestClass]
    public class DateBlComponentTests
    {
        [TestMethod]
        public void GetDateDifference_ShouldReturnValidResult()
        {
            SplittedDate date1 = new SplittedDate(1, 1, 2010);
            SplittedDate date2 = new SplittedDate(3, 1, 2010);

            DateBlComponent dateBlComponent = new DateBlComponent();

            int diff = dateBlComponent.GetDateDifference(date1, date2);

            Assert.AreEqual(2, diff);

        }
    }
}
