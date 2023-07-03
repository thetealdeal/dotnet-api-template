var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
// Just expose Swagger for now
app.UseSwagger();
app.UseSwaggerUI();

// TODO I don't like this, but I also don't like FAILED TO DETERMINE THE HTTPS PORT FOR REDIRECT on a Sunday night
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
