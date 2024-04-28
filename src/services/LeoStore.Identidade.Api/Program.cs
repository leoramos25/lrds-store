using LeoStore.Identidade.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfiguration(builder.Configuration, builder.Environment);
builder.Services.AddSwaggerConfiguration();
builder.Services.AddIdentityConfiguration(builder.Configuration);

var app = builder.Build();

app.UseApiConfiguration();
