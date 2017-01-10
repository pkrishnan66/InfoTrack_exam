using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;


namespace InfoTrackExam.ProcessingLogic
{
   public static class BuildGoogleSearchSequence
    {
       public static string BuildGoogleSearchResponse(string queryString)
       {
           string responseFromServer ="";
           WebRequest request = WebRequest.Create(queryString);
      
           // If required by the server, set the credentials.
           request.Credentials = CredentialCache.DefaultCredentials;
           // Get the response.
           try
           {
               WebResponse response = request.GetResponse();

               Stream dataStream = response.GetResponseStream();
               StreamReader reader = new StreamReader(dataStream);

               //Copy the entire content for the search Result.
               responseFromServer = reader.ReadToEnd();
           }
           catch (Exception ex)
           {
               responseFromServer = ex.Message.ToString();
           }
           
               return responseFromServer;
 
           
       }
    }
}
