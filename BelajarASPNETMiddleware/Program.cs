#region MATERI-MIDDLEWARE
// Middleware --> software that's assembled into an app pipeline to handle
//                request and responses.
// Each Component :

//var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

// -------------------------------------------------------------------------------
// PENGENALAN MIDDLEWARE
// -------------------------------------------------------------------------------
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Hello World from first delegate!\r\n");
//    await next.Invoke();
//});

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Hello World from second delegate!\r\n");
//    await next.Invoke();
//});

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello World from third delegate!");
//});

//app.Run();


// -------------------------------------------------------------------------------
// APP.MAP
// -------------------------------------------------------------------------------
//app.Map("/map1", HandleMap1);
//app.Map("/map2", HandleMap2);
//app.Map("/map1/seg1", HandleMultySeg); //GAGAL

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello from Map delegate!");
//});

//app.Run();

//static void HandleMap1(IApplicationBuilder app)
//{
//    app.Run(async context =>
//    {
//        await context.Response.WriteAsync("Map 1");
//    });
//}

//static void HandleMap2(IApplicationBuilder app)
//{
//    app.Run(async context =>
//    {
//        await context.Response.WriteAsync("Map 2");
//    });
//}

//static void HandleMultySeg(IApplicationBuilder app)
//{
//    app.Run(async context =>
//    {
//        await context.Response.WriteAsync("Map Segment 1");
//    });
//}

// -------------------------------------------------------------------------------
// APP.MAPWHEN
// -------------------------------------------------------------------------------
//app.MapWhen(context => context.Request.Query.ContainsKey("branch"), HandleBranch);

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello from non-Map delegate.");
//});

//app.Run();

//static void HandleBranch(IApplicationBuilder app)
//{
//    app.Run(async context =>
//    {
//        var branchVer = context.Request.Query["branch"];
//        await context.Response.WriteAsync($"Branch used = {branchVer}");
//    });
//}

// -------------------------------------------------------------------------------
// APP.MAP MULTY
// -------------------------------------------------------------------------------
//app.Map("/newbranch", a =>
//{
//    a.Map("/branch1", brancha => brancha
//        .Run(c => c.Response.WriteAsync("Running from the newbranch/branch1 ")));
//    a.Map("/branch2", brancha => brancha
//        .Run(c => c.Response.WriteAsync("Running from the newbranch/branch2 ")));

//    a.Run(c => c.Response.WriteAsync("Running from the newbranch"));
//});

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("<br>Another Hello, World!");
//});

//app.Run();
#endregion

using BelajarASPNETMiddleware;
using Microsoft.AspNetCore;

public class Program
{
    public static void Main(string[] args)
    {
        CreateWebHostBuilder(args).Build().Run();
    }

    private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>();
}