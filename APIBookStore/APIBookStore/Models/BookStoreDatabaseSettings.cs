namespace APIBookStore.Models
{
    public class BookStoreDatabaseSettings
    {
        // Criado classe para armazenar essas configurações
        // Adicionar esse serciço no Program.cs
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string BooksCollectionName { get; set; } = null!;
    }
}
