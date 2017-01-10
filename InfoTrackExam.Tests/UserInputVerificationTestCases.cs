using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace InfoTrackExam.Tests
{
    [TestClass]
    public class UserInputVerificationTestCases
    {
        [TestMethod]
        public void VerifyKeywordInput()
        {
            string expectedResult = "Please Enter Seach Keyword and URL to Proceed!";
            string searchKeyword = "";
            string searchUrl = "Https://www.Infotrack.com.au";
            Assert.AreEqual(expectedResult, InfoTrackExam.ProcessingLogic.BuildVerificationLogicSequence.BuildVerificationLogicResponse(searchKeyword, searchUrl));
            
        }

        [TestMethod]
        public void VerifyUrlInput()
        {
            string expectedResult = "Please Enter Seach Keyword and URL to Proceed!";
            string searchKeyword = "Infotrack";
            string searchUrl = "";
            Assert.AreEqual(expectedResult, InfoTrackExam.ProcessingLogic.BuildVerificationLogicSequence.BuildVerificationLogicResponse(searchKeyword, searchUrl));
            
        }

        [TestMethod]
        public void VerifyNoInput()
        {
            string expectedResult = "Please Enter Seach Keyword and URL to Proceed!";
            string searchKeyword = "";
            string searchUrl = "";
            Assert.AreEqual(expectedResult, InfoTrackExam.ProcessingLogic.BuildVerificationLogicSequence.BuildVerificationLogicResponse(searchKeyword, searchUrl));
            
        }

        [TestMethod]
        public void VerifyKeywordForNullInput()
        {
            string expectedResult = "Please Enter Seach Keyword and URL to Proceed!";
            string searchKeyword = null;
            string searchUrl = "Https://www.Infotrack.com.au";
            Assert.AreEqual(expectedResult, InfoTrackExam.ProcessingLogic.BuildVerificationLogicSequence.BuildVerificationLogicResponse(searchKeyword, searchUrl));
       
        }

        [TestMethod]
        public void VerifyUrlForNullInput()
        {
            string expectedResult = "Please Enter Seach Keyword and URL to Proceed!";
            string searchKeyword = "infotrack";
            string searchUrl = null;
            Assert.AreEqual(expectedResult, InfoTrackExam.ProcessingLogic.BuildVerificationLogicSequence.BuildVerificationLogicResponse(searchKeyword, searchUrl));

        }

        [TestMethod]
        public void VerifyNullInput()
        {
            string expectedResult = "Please Enter Seach Keyword and URL to Proceed!";
            string searchKeyword = null;
            string searchUrl = null;
            Assert.AreEqual(expectedResult, InfoTrackExam.ProcessingLogic.BuildVerificationLogicSequence.BuildVerificationLogicResponse(searchKeyword, searchUrl));

        }



    }
}
