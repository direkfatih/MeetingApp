var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
// **request pipeline
// authentication
// routing
// controllers 
// views
// authorization
// razor
// rest api

// url/controller/action/id?

//app.MapGet("/", () => "Hello World!");

app.MapDefaultControllerRoute();

app.Run();
