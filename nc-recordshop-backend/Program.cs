using nc_recordshop_backend.Service;
using nc_recordshop_backend.Repository;
using Microsoft.EntityFrameworkCore;


namespace nc_recordshop_backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO now
            // Add exception handling
            // Add new test for the recently added new functionality and have it function with the exception handling
            // Check if all _db.SaveChanges() will need to become async (for the exceptions)
            // Fix Production - Develop databases, so simply changing environtment variables will work
            // Remove temp SwaggerUI usage from production



            // In Package Manager Console
            //
            // Add-Migration mig1
            // Update-Database
            // $env:ASPNETCORE_ENVIRONMENT='Production'













            var builder = WebApplication.CreateBuilder(args);
            //builder.Environment.IsDevelopment()
            /*if (builder.Environment.IsProduction())
            {
                Console.WriteLine("PROD Database");
                builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProdDefaultConnection")));
            }*/
            Console.WriteLine("PROD Database");
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connectionString));
            /*else
            {
                Console.WriteLine("In Memory Database");
                builder.Services.AddDbContext<MyDbContext>(options => options.UseInMemoryDatabase("DevDefaultConnection"));
            }*/

            //builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



            /*if (builder.Environment.IsDevelopment())
            {
                Console.WriteLine("Is in Development, using in memory db");
                builder.Services.AddInMemoryDatabases;
            }*/

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IAlbumService, AlbumService>();
            builder.Services.AddScoped<IAlbumRepository, AlbumRepository>();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddTransient<ExceptionHandlerMiddleWare>();


            var app = builder.Build();

            app.UseMiddleware<ExceptionHandlerMiddleWare>();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Temp
            if (app.Environment.IsProduction())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
