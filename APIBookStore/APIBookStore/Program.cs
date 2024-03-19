using APIBookStore.Models;
using APIBookStore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Instancia de configura��o e configura��es do banco de dados
builder.Services.Configure<BookStoreDatabaseSettings>(
    builder.Configuration.GetSection("BookStoreDatabase"));

// Adicionar um servi�o chamado BooksService, criando um servi�o singleton
builder.Services.AddSingleton<BooksService>();


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
