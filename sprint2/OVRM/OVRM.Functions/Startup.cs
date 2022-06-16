using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using OVRM.DAL;

[assembly: FunctionsStartup(typeof(OVRM.Functions.Startup))]
namespace OVRM.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string sqlCS = Environment.GetEnvironmentVariable("sqlCS");
            builder.Services.AddDbContext<OVRMDBContext>((options) => options.UseSqlServer(sqlCS));
        }

    }
}
