
using InstaDough.Core.BusinessManager.Interface;
using InstaDough.Employee.Web.API.App_Start;
using InstaDough.Repository;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<EmployeeInstaDoughContext>(options =>
//options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeInstaDoughContext")));

builder.Services.AddSingleton<IDispatcher>(DispatcherConfig.RegisterComponents());
RepositoryConfig.RegisterCompnents();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corspolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
