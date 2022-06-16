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
    public class VehicleController : Controller
    {
        public IConfiguration Configuration { get; private set; }

        public VehicleController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        public IActionResult CreateVehicle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateVehicle(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string cs = Configuration.GetConnectionString("storageCS");
                    BlobServiceClient client = new BlobServiceClient(cs);
                    string container = "vehicles";
                    BlobContainerClient containerClient = client.GetBlobContainerClient(container);
                    containerClient.CreateIfNotExists();
                    BlobClient blobClient = containerClient.GetBlobClient(Guid.NewGuid().ToString());
                    blobClient.Upload(new BinaryData(vehicle));
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View(vehicle);
        }

    }
}
