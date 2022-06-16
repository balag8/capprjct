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
    public class Booking_DetailsController : Controller
    {
        public IConfiguration Configuration { get; private set; }


        public Booking_DetailsController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        public IActionResult CreateBooking_Details()
        {
            return View();          //when Requested returns the view 
        }

        [HttpPost]
        public IActionResult CreateBooking_Details(Booking_Detail Booking_Detail)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string cs = Configuration.GetConnectionString("storageCS"); //connection name
                    BlobServiceClient client = new BlobServiceClient(cs);   // connect with storage account
                    String Container = "Booking_Detail";
                    BlobContainerClient containerClient = client.GetBlobContainerClient(Container);  //connect with blob container
                    containerClient.CreateIfNotExists();    //container client.create is not exist it will create it
                    BlobClient blobClient = containerClient.GetBlobClient(Guid.NewGuid().ToString());
                    blobClient.Upload(new BinaryData(Booking_Detail));     //blob will only accept binary data so pass binary data
                    return RedirectToAction("Index", "Home");     //after complete we will redirect to home page so use action 

                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(" ", ex.Message);
                }
            }
            return View(Booking_Detail);  //if model is not there and stay back on current view 
        }
    }
}
