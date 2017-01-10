using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InfoTrackExam.Tests
{
    [TestClass]
    public class ResultVerificationTestCases
    {
        [TestMethod]
        public void VerifyResultForValidUrlInput()
        {
            string url = "http://www.thegrowthfaculty.com.au";
            string keyword = "infotrack";
            string expectedResult = url + " found in Google within First 100 results";
            Assert.AreEqual(expectedResult, InfoTrackExam.ProcessingLogic.BuildVerificationLogicSequence.BuildVerificationLogicResponse(keyword, url));

        }

        [TestMethod]
        public void VerifyResultForInvalidUrlInput()
        {
            string url = "http://www.PrashanthKrishnan.com.au";
            string keyword = "infotrack";
            string expectedResult = url + " not found in Google within First 100 results";
            Assert.AreEqual(expectedResult, InfoTrackExam.ProcessingLogic.BuildVerificationLogicSequence.BuildVerificationLogicResponse(keyword, url));

        }

        [TestMethod]
        public void VerifyResultForValidKeywordInput()
        {
            string keyword = "info";
            string url = "https://www.Infotrack.com.au";
            string expectedResult = url + " not found in Google within First 100 results";

            Assert.AreEqual(expectedResult, InfoTrackExam.ProcessingLogic.BuildVerificationLogicSequence.BuildVerificationLogicResponse(keyword, url));

        }

        [TestMethod]
        public void VerifyResultForValidKeywordInputSecondTest()
        {
            string keyword = "test";
            string url = "https://www.gov.uk/change-driving-test";
            string expectedResult = url + " found in Google within First 100 results";

            Assert.AreEqual(expectedResult, InfoTrackExam.ProcessingLogic.BuildVerificationLogicSequence.BuildVerificationLogicResponse(keyword, url));

        }

        [TestMethod]
        public void VerifyResultForValidKeywordAtHundrethPosition()
        {
            string keyword = "test";
            string url = "https://www.faaPrashanth.gov/";
            string expectedResult = url + " not found in Google within First 100 results";

            Assert.AreEqual(expectedResult, InfoTrackExam.ProcessingLogic.BuildVerificationLogicSequence.BuildVerificationLogicResponse(keyword, url));

        }

    }
}
