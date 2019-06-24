using System;
using System.Collections.Generic;
using System.Text;
using AmazonCosplay.Interfaces;
using AmazonCosplay.Model;
using AmazonCosplay.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AmazonCosplay
{
    public class TestDependencyInjection
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRepository<Book>, Repository<Book>>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}
