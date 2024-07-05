var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Api>("weather-api");
builder.AddProject<Projects.MyWeatherHub>("web-frontend");

builder.Build().Run();
