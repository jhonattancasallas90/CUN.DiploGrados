﻿using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using CUN.DiploGrados.Services.WebApi.Modules.Authentication;
using CUN.DiploGrados.Services.WebApi.Modules.Feature;
using CUN.DiploGrados.Services.WebApi.Modules.HealthCheck;
using CUN.DiploGrados.Services.WebApi.Modules.Injection;
using CUN.DiploGrados.Services.WebApi.Modules.Mapper;
using CUN.DiploGrados.Services.WebApi.Modules.Swagger;
using CUN.DiploGrados.Services.WebApi.Modules.Validator;
using CUN.DiploGrados.Services.WebApi.Modules.Versioning;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddMapper();
builder.Services.AddFeature(builder.Configuration);
builder.Services.AddInjection(builder.Configuration);
builder.Services.AddAuthentication(builder.Configuration);
builder.Services.AddVersioning();
builder.Services.AddSwagger();
builder.Services.AddValidator();
builder.Services.AddHealthCheck(builder.Configuration);

var app = builder.Build();

// configure the Http request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        // build a swagger endpoint for each discovered API version
        var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
        foreach (var description in provider.ApiVersionDescriptions)
        {
            c.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
        }
    });
}

app.UseHttpsRedirection();
app.UseCors("policyApiEcommerce");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapHealthChecksUI();
app.MapHealthChecks("/health", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions
{
    Predicate = _ => true,
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

app.Run();

public partial class Program { };