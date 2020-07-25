using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AzureBlobPractice.Models;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;
using Microsoft.Extensions.Configuration;
using System.IO;
using AzureBlobPractice.Services;

namespace AzureBlobPractice.Controllers
{
    public class HomeController : Controller
    {
        private IAzureBlobService azureBlobService;

        public HomeController(IAzureBlobService azureBlobService)
        {
            this.azureBlobService = azureBlobService;
        }
        public async Task<ActionResult> Index()
        {
            try
            {
                var allBlobs = await azureBlobService.ListAsync();
                return View(allBlobs);
            }
            catch (Exception ex)
            {
                ViewData["message"] = ex.Message;
                ViewData["trace"] = ex.StackTrace;
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<ActionResult> UploadAsync()
        {
            try
            {

                var request = await HttpContext.Request.ReadFormAsync();
                if( request.Files == null)
                {
                    return BadRequest("Could not upload files");
                }
                var files = request.Files;
                if(files.Count == 0)
                {
                    return BadRequest("Could not upload empty files");
                }

                await azureBlobService.UploadAsync(files);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewData["message"] = ex.Message;
                ViewData["trace"] = ex.StackTrace;
                return View("Error");
            }
        }


        [HttpPost]
        public async Task<ActionResult> DeleteImage(string name)
        {
            try
            {

                await azureBlobService.DeleteAsync(name);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewData["message"] = ex.Message;
                ViewData["trace"] = ex.StackTrace;
                return View("Error");
            }
        }


        [HttpPost]
        public async Task<ActionResult> DeleteAll()
        {
            try
            {
                await azureBlobService.DeleteAllAsync();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewData["message"] = ex.Message;
                ViewData["trace"] = ex.StackTrace;
                return View("Error");
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
