using ApiGateway.Configurations;

var builder = WebApplication.CreateBuilder(args);

// The below is used when getting configurations from the appsettings.json file
//builder.Services.AddReverseProxy().LoadFromConfig(builder.Configuration.GetSection("ApiGateway"));

// The below is injected when getting configurations from the config class
builder.Services.AddReverseProxy().LoadFromMemory(ApiGatewayConfiguration.GetRoutes(), ApiGatewayConfiguration.GetClusters());


var app = builder.Build();

app.MapReverseProxy();

app.Run();
