using School.BusinessLayer.Concrete;
using School.DataAccessLayer;
using School.DataAccessLayer.Repositories.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<SchoolDbContext>();
builder.Services.AddScoped<UnitOfWork>();
builder.Services.AddScoped<LessonRepository>();
builder.Services.AddScoped<TeacherRepository>();
builder.Services.AddScoped<LessonBusiness>();
builder.Services.AddScoped<TeacherBusiness>();  
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
