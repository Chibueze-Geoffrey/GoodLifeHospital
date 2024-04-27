using GoodLifeHospital.DatabaseContext;
using GoodLifeHospital.Services.Implementations;
using GoodLifeHospital.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson()
.AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
builder.Services.AddDbContext<GoodLifeContext>(options =>
               options.UseSqlite("Data Source = GoodLife.Db"));

//builder.Services.AddDbContext<GoodLifeContext>(options =>
//        options.UseSqlServer(builder.Configuration.GetConnectionString("HospitalDatabase")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
