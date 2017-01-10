using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoTrackExam.ProcessingLogic
{
    public static class BuildHrefSequence
    {
        public static List<string> BuildHrefResponse(string orderedList, List<string> hrefList)
        {

            if (orderedList.IndexOf("<table") != -1)
            {
                int startTableIndex = orderedList.IndexOf("<table");
                int endTableIndex = orderedList.IndexOf("</table>");
                orderedList = orderedList.Remove(startTableIndex, endTableIndex - startTableIndex);
            }

            
                int startIndex = 0;
                int endIndex = 0;

                //This is a pattern to observe in the extract...
                //This pattern is followed by the URL 

                while (orderedList.IndexOf("<h3 class=\"r\"><a href=") != -1 && hrefList.Count < 100)
                {
                    startIndex = orderedList.IndexOf("<h3 class=\"r\"><a href=");
                    endIndex = orderedList.IndexOf("</a></h3>");
                    
                    hrefList.Add(orderedList.Substring(startIndex, endIndex + 9 - startIndex));

                    //Remove the pervious pattern..to go to next url..
                    orderedList = orderedList.Remove(startIndex, 22);
                    orderedList = orderedList.Remove(endIndex - 22, 9);

                    startIndex = 0;
                    endIndex = 0;
                }
            


            return hrefList;

        }
    }
}
