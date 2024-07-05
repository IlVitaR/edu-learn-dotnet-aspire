var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.Api>("weather-api");
builder.AddProject<Projects.MyWeatherHub>("web-frontend").WithReference(api);

builder.Build().Run();
