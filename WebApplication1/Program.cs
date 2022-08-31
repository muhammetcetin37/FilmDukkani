var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var constr = builder.Configuration.GetConnectionString("WebApiDb");
builder.Services.AddDbContext<SqlDbcontext>(options =>
{
    options.UseSqlServer(constr);
});

//category Servisini Container icerisine register ediyoruz

//builder.Services.AddScoped<ISehirDAL, SehirDAL>();
//builder.Services.AddScoped<IilceDAL, IlceDAL>();

#region CORS Ayarlarinin ekenmesi
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(p =>
    p.AllowAnyHeader()
    .AllowAnyOrigin()
    .AllowAnyMethod());
});

#endregion
var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Cors'u MiddleWare icerisine ekliyoruz
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();