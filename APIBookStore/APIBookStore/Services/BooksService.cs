using APIBookStore.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace APIBookStore.Services
{
    public class BooksService
    {
        // Criando nosso serviço
        // Serviço de conexão

        // Chamar a collection do MongoDB
        private readonly IMongoCollection<Book> _booksCollection;
        public BooksService(
            IOptions<BookStoreDatabaseSettings> bookStoreDatabaseSettings)
        {
            // Responsável por se conectar ao servidor MongoDB
            var mongoClient = new MongoClient(
                bookStoreDatabaseSettings.Value.ConnectionString);

            // Referencia o nome do banco de dados
            var mongoDatabase = mongoClient.GetDatabase(
                bookStoreDatabaseSettings.Value.DatabaseName);

            // Referência á coleção de livros no banco de dados
            // _booksCollection será usado posteriormente para interagir com os documentos na coleção de livros
            _booksCollection = mongoDatabase.GetCollection<Book>(
                bookStoreDatabaseSettings.Value.BooksCollectionName);
        }

        // Get - geral
        // Procurar todos os itens da lista
        public async Task<List<Book>>GetBooksAsync() => 
            await _booksCollection.Find(_=> true).ToListAsync();

        // Get - por Id
        public async Task<Book?>GetAsync(string id) =>
            await _booksCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        // Create async
        // Método é responsável por adicionar um novo livro na coleção
        public async Task CreateAsync(Book newBook) => 
            await _booksCollection.InsertOneAsync(newBook);

        // Update
        // Esse método é usado para atualizar um livro existente com base no Id
        public async Task UpdateAsync(string id, Book updatedBook) =>
            await _booksCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        // Delete
        // Exclui um livro da coleção com base no I
        public async Task RemoveAsync(string id) =>
            await _booksCollection.DeleteOneAsync(x => x.Id == id);
    }
}
