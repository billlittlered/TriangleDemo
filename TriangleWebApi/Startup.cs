﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GridLibrary.Implementations;
using GridLibrary.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace TriangleWebApi
{
     public class Startup
     {
          public Startup(IConfiguration configuration)
          {
               Configuration = configuration;
          }

          public IConfiguration Configuration { get; }

          // This method gets called by the runtime. Use this method to add services to the container.
          public void ConfigureServices(IServiceCollection services)
          {
               services.AddCors(options =>
               {
                    options.AddPolicy("CorsPolicy",
                     builder => builder.WithOrigins("http://localhost:4200")
                                             .AllowAnyMethod()
                                            .AllowCredentials()
                                            .AllowAnyHeader());
               });
               services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                    .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
               services.AddSingleton<IGrid, Grid>();
               services.AddSingleton<ICoordinate, Coordinate>();
          }

          // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
          public void Configure(IApplicationBuilder app, IHostingEnvironment env)
          {
               if (env.IsDevelopment())
               {
                    app.UseDeveloperExceptionPage();
               }

               app.UseCors("CorsPolicy");
               app.UseMvc();
               app.UseMvc(routes =>
               {
                    routes.MapRoute(
                     name: "default",
                     template: "{controller}/{action=Index}/{id?}");
               });
          }
     }
}
