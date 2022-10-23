using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using ProjectWe.Services;
using ProjectWe.Services.Database;
using ProjectWe.Services.ProjectStateMachine;
using Microsoft.OpenApi.Models;
using ProjectWe;
using ProjectWe.Filters;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers( config =>
{
    config.Filters.Add<ErrorFilter>();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( config =>
{
    config.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.Http,
        Scheme = "basic"
    });

    config.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
            },
            new string[]{}
        }
    });
});

builder.Services.AddTransient<IUsersService, UsersService>();
builder.Services.AddTransient<IProjectsService, ProjectsService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IObjectivesService, ObjectivesService>();

builder.Services.AddTransient<BaseState>();
builder.Services.AddTransient<InitialProjectState>();
builder.Services.AddTransient<DraftProjectState>();
builder.Services.AddTransient<ActiveProjectState>();

builder.Services.AddAutoMapper(typeof(IUsersService));
builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

builder.Services.AddDbContext<_160020Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
