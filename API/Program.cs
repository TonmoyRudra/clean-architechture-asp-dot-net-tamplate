using API.Errors;
using Application.Core;
using Application.Features.Menu;
using Application.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Persistence;
using Persistence.Repositories;
using Persistence.Services;
using System.Collections.Generic;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var filePathConfig = builder.Configuration["StoredFilePath"];

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(typeof(AutomapperProfile).Assembly);
builder.Services.AddScoped(typeof(IReposotory<>), typeof(Repository<>));
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ITokenService, TokenService>();


builder.Services.AddMediatR(typeof(List.Handler));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opts => {

    opts.TokenValidationParameters = new TokenValidationParameters
    {
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:Key"])),
        ValidIssuer = builder.Configuration["Token:Issuer"],
        ValidateIssuer = true,
        ValidateAudience = false
    };

});


builder.Services.AddAuthorization(options =>
{
    //options.AddPolicy("AdminOnly", policy => policy.RequireClaim("45"));

    options.AddPolicy(
        "AdminOnly",
        policyBuilder => policyBuilder.RequireAssertion(
            context => context.User.IsInRole("45"))
    );

    options.AddPolicy(
       "AdminCertificateView",
       policyBuilder => policyBuilder.RequireAssertion(
           context => context.User.IsInRole("49") || context.User.IsInRole("45"))
   );

    options.AddPolicy(
    "WPPFAdmin",
    policyBuilder => policyBuilder.RequireAssertion(
        context => context.User.IsInRole("49"))
);

});


builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", policy =>
    {
        // policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200");
        policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});

builder.Services.Configure<FormOptions>(o =>
{
    o.ValueLengthLimit = int.MaxValue;
    o.MultipartBodyLengthLimit = int.MaxValue;
    o.MemoryBufferThreshold = int.MaxValue;
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();

app.UseStatusCodePagesWithReExecute("/Errors/{0}");
app.UseHttpsRedirection();

app.UseRouting();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), builder.Configuration["DocFilePath"])
                ),
    RequestPath = "/content"
});



app.UseCors("CorsPolicy");

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapFallbackToController("Index", "Fallback");
});

var scope = app.Services.CreateScope();

var context = scope.ServiceProvider.GetRequiredService<DataContext>();  //app.Services.GetRequiredService<DataContext>();
await context.Database.MigrateAsync();

app.Run();
