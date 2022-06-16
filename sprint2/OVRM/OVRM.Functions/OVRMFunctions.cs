using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OVRM.DAL;
using OVRM.Entities;

namespace OVRM.Functions
{
    public class OVRMFunctions
    {
        public readonly OVRMDBContext _dal;
        public OVRMFunctions(OVRMDBContext dal)
        {
            _dal = dal;
            _dal.Database.EnsureCreated();

        }
        
        [FunctionName("CreateAdmin")]
        public async Task<IActionResult> CreateAdmin(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            Admin admin = JsonConvert.DeserializeObject<Admin>(requestBody);
            await _dal.Admins.AddAsync(admin);
            await _dal.SaveChangesAsync();
            return new OkObjectResult(admin);
              
        }
        [FunctionName("CreateCustomer")]
        public async Task<IActionResult> CreateCustomer(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            Customer customer = JsonConvert.DeserializeObject<Customer>(requestBody);
            await _dal.Customers.AddAsync(customer);
            await _dal.SaveChangesAsync();
            return new OkObjectResult(customer);

        }
        [FunctionName("CreateVehicle")]
        public async Task<IActionResult> CreateVehicle(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            Vehicle vehicle = JsonConvert.DeserializeObject<Vehicle>(requestBody);
            await _dal.Vehicles.AddAsync(vehicle);
            await _dal.SaveChangesAsync();
            return new OkObjectResult(vehicle);

        }
        [FunctionName("CreateBooking_Details")]
        public async Task<IActionResult> CreateBooking_Details(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            Booking_Detail booking_Detail = JsonConvert.DeserializeObject<Booking_Detail>(requestBody);
            await _dal.Booking_Details.AddAsync(booking_Detail);
            await _dal.SaveChangesAsync();
            return new OkObjectResult(booking_Detail);

        }
        [FunctionName("CreatePayment")]
        public async Task<IActionResult> CreatePayment(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            Payment payment = JsonConvert.DeserializeObject<Payment>(requestBody);
            await _dal.Payments.AddAsync(payment);
            await _dal.SaveChangesAsync();
            return new OkObjectResult(payment);

        }
        [FunctionName("CreateActiveBooking")]
        public async Task<IActionResult> CreateActiveBooking(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            ActiveBooking activeBooking = JsonConvert.DeserializeObject<ActiveBooking>(requestBody);
            await _dal.ActiveBookings.AddAsync(activeBooking);
            await _dal.SaveChangesAsync();
            return new OkObjectResult(activeBooking);

        }
    }
}
