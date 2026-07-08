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

            if (builder.Environment.IsProduction())
            {
                Console.WriteLine("PROD Database");
                string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
                builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connectionString));
            }
            else if (builder.Environment.IsDevelopment())
            {
                Console.WriteLine("In Memory Database");
                builder.Services.AddDbContext<MyDbContext>(options => options.UseInMemoryDatabase("DefaultConnection"));
            }

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IAlbumService, AlbumService>();
            builder.Services.AddScoped<IAlbumRepository, AlbumRepository>();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddTransient<ExceptionHandlerMiddleWare>();


            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<MyDbContext>();
                if (builder.Environment.IsProduction())
                {
                    db.Database.Migrate();
                }

                else if (app.Environment.IsDevelopment())
                {
                    db.Database.EnsureCreated();
                }

            }

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
