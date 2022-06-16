using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Online_Vehicle_Rental_management.API.Controllers;
using Online_Vehicle_Rental_management.DAL.API;
using System.Collections.Generic;
using System.Linq;
using Online_Vehicle_Rental_management.Entities.API;
using Microsoft.EntityFrameworkCore;

namespace Online_Vehcle_Rental_management.API.UnitTests
{
    [TestClass]
    public class AdminsAPIControllerUnitTest
    {
        [TestMethod]
        public void GetTest()
        {
            var options = SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), "SERVER=DESKTOP-CUVVVBD\\SQLEXPRESS;DATABASE=Ovrm;TRUSTED_CONNECTION=TRUE;MULTIPLEACTIVERESULTSETS=TRUE;").Options;
            var DbContext = new OVRMDbContext(options);
            var controller = new AdminsAPIController(DbContext);
            var getresult = controller.GetAdmins().Result.Value;

            Assert.IsInstanceOfType(getresult, typeof(IEnumerable<Admin>));
        }
    }
}
