using nc_recordshop_backend.Service;
using nc_recordshop_backend.Repository;
using Microsoft.EntityFrameworkCore;


namespace nc_recordshop_backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<MyDbContext>(options => options.UseInMemoryDatabase("AlbumTestingDb"));
            

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


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
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
