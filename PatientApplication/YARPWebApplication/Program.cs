using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddReverseProxy()
     .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));
//CMD COMMAND : dotnet dev-certs https --trust

//below is the configuration for forward proxy.
builder.Services.Configure<ForwardedHeadersOptions>(options => {
    options.ForwardedHeaders = ForwardedHeaders.All;
});
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
app.MapReverseProxy();

app.Run();
