using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using OVRM.Entities;

namespace OVRM.Web.Controllers
{
    public class ActiveBookingController : Controller
    {
        public IConfiguration Configuration { get; private set; }

        public ActiveBookingController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        public IActionResult CreateActiveBooking()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateActiveBooking(ActiveBooking activeBooking)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string cs = Configuration.GetConnectionString("storageCS");
                    BlobServiceClient client = new BlobServiceClient(cs);
                    string container = "activebooking";
                    BlobContainerClient containerClient = client.GetBlobContainerClient(container);
                    containerClient.CreateIfNotExists();
                    BlobClient blobClient = containerClient.GetBlobClient(Guid.NewGuid().ToString());
                    blobClient.Upload(new BinaryData(activeBooking));
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View(activeBooking);
        }

    }
}
