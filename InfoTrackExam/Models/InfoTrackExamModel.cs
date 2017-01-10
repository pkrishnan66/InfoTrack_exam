using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InfoTrackExam.ProcessingLogic;
using System.Configuration;

namespace InfoTrackExam.Models
{
    public class InfoTrackExamModel
    {
        public string verificationResult { get; set; }

        public string performVerification(string searchKey, string searchUrl)
        {
            return InfoTrackExam.ProcessingLogic.BuildVerificationLogicSequence.BuildVerificationLogicResponse(searchKey, searchUrl);
        }
       
    }
}