using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace InfoTrackExam.ProcessingLogic
{
    public static class BuildVerificationLogicSequence
    {
        public static string BuildVerificationLogicResponse(string searchKey, string searchUrl)
       {
           string queryString = "";
           string googleSearchResult = "";
           string orderedList = "";
           string verificationResult = "";
           List<string> hrefList = new List<string>();


           if (searchKey != "" && searchKey != null && searchUrl != "" && searchUrl != null)
           {
               string[] hrefArray = new string[100];
               //11 pages need to be checked for 100 search results...
               //Iterating 
               for (int pageIndex = 1; pageIndex <= 11; pageIndex++)
               {
                   if (hrefList.Count < 100)
                   {
                       switch (pageIndex > 1)
                       {
                           case false:
                               queryString = ConfigurationManager.AppSettings["GoogleUrl"] + "search?q=" + searchKey;
                               break;
                           case true:
                               queryString = ConfigurationManager.AppSettings["GoogleUrl"] + "search?q=" + searchKey + "&start=" + (pageIndex - 1) * 10;
                               break;
                       }

                       //Next step is to build Google Search Response sequence...
                       googleSearchResult = BuildGoogleSearchSequence.BuildGoogleSearchResponse(queryString);

                       if (googleSearchResult != "The remote server returned an error: (503) Server Unavailable.")
                       {
                           //perform first level filtering and grab ordered List from the google Search Result...
                           orderedList = BuildFilteredSearchSequence.BuildFilteredSearchResponse(googleSearchResult);

                           //Perform second Level filtering and grab the href data from the ordered List generated above
                           hrefList = BuildHrefSequence.BuildHrefResponse(orderedList, hrefList);
                       }
                       else
                       {
                           verificationResult = googleSearchResult;
                           break;
                       }
                   }
               }
               verificationResult = BuildUrlVerificationSequence.VerifiyUrlResponse(hrefList, searchUrl);
           }
           else
           {
                verificationResult = "Please Enter Seach Keyword and URL to Proceed!";

           }
           return verificationResult;

       }
    }
}
