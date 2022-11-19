using Formul.BLL;
using Formul.BLL.Abstarct;
using Formul.BLL.Concret;
using Formul.DAL;
using Formul.DAL.Abstract;
using Formul.DAL.Concret;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("AppDb"));
});
builder.Services.AddScoped<IParametrRepo, ParametrRepo>();
builder.Services.AddScoped<IParametrService, ParametrService>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddScoped<IFormulaRepo,FormulaRepo>();
builder.Services.AddScoped<IFormulaService, FormulaService>();

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
