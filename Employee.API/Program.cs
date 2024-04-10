using Employee.Core.Repositories;
using Employee.Core.Service;
using Employee.Data.Repositories;
using Employee.Data;
using Employee.Service;
using Employee.Servies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Employee.Core;
using AutoMapper;

namespace Employee.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Employee API", Version = "v1" });
            });

            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IRoleService, RoleService>();
            builder.Services.AddScoped<IRoleRepository, RoleRepository>();

            builder.Services.AddDbContext<DataContext>();
            builder.Services.AddAutoMapper(typeof(Mapper), typeof(MapperProfile));

           

            builder.Services.AddCors(opt => opt.AddPolicy("policy", policy =>
                    {
                        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                    }));

            var app = builder.Build();
           // app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee API v1"));

            app.UseHttpsRedirection();
            app.UseCors("policy");
            app.UseRouting();

            app.UseAuthorization();
           
            app.MapControllers();

            app.Run();

        }
    }
}
