using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using InfoTrackExam.Models;

namespace InfoTrackExam.Controllers
{
    public class InfoTrackController : Controller
    {
        //
        // GET: /InfoTrack/

        public ActionResult InfoTrackExam()
        {
           
            return View();
        }

        [HttpGet]
        public string VerifyUrlInGoogleSearchResult(string searchKeyword, string searchUrl)
        {
            InfoTrackExamModel infoTrackExamModel = new InfoTrackExamModel();
            infoTrackExamModel.verificationResult = infoTrackExamModel.performVerification(searchKeyword, searchUrl);

            return infoTrackExamModel.verificationResult;

        }


    }
}
