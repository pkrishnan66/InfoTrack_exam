using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoTrackExam.ProcessingLogic
{
   public static class BuildFilteredSearchSequence
    {
       public static string BuildFilteredSearchResponse(string googleSearchResult)
       {
           //Grab the Complete Ordered List...
           int startIndex = googleSearchResult.IndexOf("<ol>");
           if (startIndex >= 0)
           {
               googleSearchResult = googleSearchResult.Substring(startIndex - 1);
           }
           int endIndex = googleSearchResult.IndexOf("</ol>");
           googleSearchResult = googleSearchResult.Substring(1, endIndex + 4);
           return googleSearchResult;
       }
    }
}
