using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Online_Vehicle_Rental_management.API.Controllers;
using Online_Vehicle_Rental_management.DAL.API;
using System.Linq;
using Online_Vehicle_Rental_management.Entities.API;
using Microsoft.EntityFrameworkCore;
namespace Online_Vehcle_Rental_management.API.UnitTests
{
    [TestClass]
    public class VehicleAPIControllerUintTest
    {
        [TestMethod]
        public void GetTest()
        {
            var options = SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), "SERVER=DESKTOP-CUVVVBD\\SQLEXPRESS;DATABASE=Ovrm;TRUSTED_CONNECTION=TRUE;MULTIPLEACTIVERESULTSETS=TRUE;").Options;
            var DbContext = new OVRMDbContext(options);
            var controller = new VehiclesAPIController(DbContext);
            var getresult = controller.GetVehicles().Result.Value;

            Assert.IsInstanceOfType(getresult, typeof(IEnumerable<Vehicle>));
        }

    }
}
