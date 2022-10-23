using Microsoft.EntityFrameworkCore;
using ProjectWe.Services;
using ProjectWe.Services.Database;
using ProjectWe.Services.ProjectStateMachine;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IUsersService, UsersService>();
builder.Services.AddTransient<IProjectsService, ProjectsService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();

builder.Services.AddTransient<BaseState>();
builder.Services.AddTransient<InitialProjectState>();
builder.Services.AddTransient<DraftProjectState>();
builder.Services.AddTransient<ActiveProjectState>();

builder.Services.AddAutoMapper(typeof(IUsersService));

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
app.UseAuthorization();
app.MapControllers();

app.Run();
