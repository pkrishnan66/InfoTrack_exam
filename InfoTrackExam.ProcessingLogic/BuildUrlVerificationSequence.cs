using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoTrackExam.ProcessingLogic
{
   public static class BuildUrlVerificationSequence
    {
       public static string VerifiyUrlResponse(List<string> hrefList, string url)
       {
           string verificationResult = url + " not found in Google Search within First 100 results";
           foreach (string href in hrefList)
           {
               if (href.Contains(url))
               {
                   verificationResult = url + " found in Google Search within First 100 results";
                   break;
               }
           }
           return verificationResult;
       }
    }
}
