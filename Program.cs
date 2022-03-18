using get_shit_done_webapi.Services;
using get_shit_done_webapi.Services.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped <ProjectService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<TaskService>();
builder.Services.AddScoped<SpecialistProjectService>();




var connectionString = builder.Configuration.GetConnectionString("GetShitDoneString");
builder.Services.AddDbContext<DataContext>(option => option.UseSqlServer(connectionString));

builder.Services.AddCors(options =>
{
    options.AddPolicy("GetShitDonePolicy",
    builder =>
    {
        builder.WithOrigins("http://localhost:3000","https://getshitsdone.azurewebsites.net")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseCors("GetShitDonePolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
