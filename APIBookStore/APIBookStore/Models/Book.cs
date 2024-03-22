using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace APIBookStore.Models
{
    public class Book
    {
        // Classe de livros -> mapeia objeto -> link para coleção do MongoDB
        // BSonID -> designar como chave primária do nosso documento

        // Criar algumas variaveis
        // Id será usado como String e podera anular (em banco relacional não pode)

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Name")]
        public string BookName { get; set; } = null!;
        public decimal Price { get; set; }
        public string Category { get; set; } = null!;

        [BsonElement("Autor")]
        public string Author { get; set; } = null!;
    }
}
