
using Newtonsoft.Json.Linq;
using NLU_Aggregator;
using System.Net.Http;

public class Program
{
    public static void Main(string[] args)
    {
        //CreateHostBuilder(args).Build().Run();
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddScoped(hc => new HttpClient { BaseAddress = new Uri("https://automation.datasphera.com/") });
        var app = builder.Build();

        // Configuration du Http request pipeline
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        var headers = new Dictionary<string, string>();
        headers.Add("email", "contact@datasphera.com");
        headers.Add("password", "Ex@cctly123");
        
        
       /* app.MapGet("explicit-http-client", async(HttpClient httpClient) => {
            //return await httpClient.PostAsJsonAsync("api/v1/auth/login/basic/default", headers).Result.ToString();//PosFromJsonAsync<List<Token>>("api/v1/auth/login/basic/default");
            var response = httpClient.PostAsJsonAsync("https://automation.datasphera.com/api/v1/auth/login/basic/default", headers).Result.Content.ReadAsStringAsync().Result;
            var json = JObject.Parse(response);
        });*/
           
        
    }

   /* public static IHostBuilder CreateHostBuilder(string[] args) =>
   Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                    .UseDefaultServiceProvider(opt =>
                    {
                        opt.ValidateOnBuild = false;
                    });
                })
            .ConfigureAppConfiguration(config => config.AddJsonFile("ocelot.json"));*/

}

/*var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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
*/