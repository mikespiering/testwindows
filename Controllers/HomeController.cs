using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.IO;

namespace TestMVC.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var mvcName = typeof(Controller).Assembly.GetName();
			var isMono = Type.GetType("Mono.Runtime") != null;

			ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  Drive type: {0}", d.DriveType);
                 
            }
            /*
            string folderName = @"x:\";
            string pathString = System.IO.Path.Combine(folderName, "testFile.txt");
            using (System.IO.FileStream fs = System.IO.File.Create(pathString))
            {
                Console.WriteLine("Writing junk to file!!!");
                for (byte i = 0; i < 100; i++)
                {
                    fs.WriteByte(i);
                }
            }
            */
            return View();
                       
		}
	}
}
