var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("output-cache");

var api = builder.AddProject<Projects.Api>("weather-api")
    .WithReference(cache);
builder.AddProject<Projects.MyWeatherHub>("web-frontend")
    .WithReference(api);

builder.Build().Run();
