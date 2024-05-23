
using MarketApplication.Commands.CreateProduct;
using MarketApplication.DbInterfaces;
using MarketPostgreDb.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace MarketWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddEntityFrameworkNpgsql().AddDbContext<MarketDbContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("SampleDbConnection")));
            builder.Services.AddControllers().AddJsonOptions(o => { o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve; o.JsonSerializerOptions.MaxDepth = 0; });
            builder.Services.AddScoped<IMarketDbContext, MarketDbContext>();
            builder.Services.AddScoped<IProductService, ProductService>();
           

            WebApplication app = builder.Build();
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
