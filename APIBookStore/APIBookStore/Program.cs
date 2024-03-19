using APIBookStore.Models;
using APIBookStore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Instancia de configuração e configurações do banco de dados
builder.Services.Configure<BookStoreDatabaseSettings>(
    builder.Configuration.GetSection("BookStoreDatabase"));

// Adicionar um serviço chamado BooksService, criando um serviço singleton
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
