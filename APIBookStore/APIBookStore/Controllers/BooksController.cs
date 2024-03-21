using APIBookStore.Services;
using APIBookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIBookStore.Controllers
{
    // Indica que essa classe é um controlador da API
    [ApiController]
    [Route("api/[controller]")] // Define o padrão de rota para esse controlador
    public class BooksController : ControllerBase // Herda a ControllerBase
    {
        // Classe -> define o comportamento e as propiedades (atributos) de um objeto
        // Controlador da API -> lida com solicitações HTTP  interpretar os dados da solicitação recebida, executar a lógica de negócios
        // e retornar uma resposta

        private readonly BooksService _booksService;

        // BooksController precisa de um serviço -> BooksServices (fornecido externamente)
        public BooksController(BooksService booksService)
        {
            _booksService = booksService; // perimite usar _bookService em qualquer método dentro de BooksController
        }

        [HttpGet]
        public async Task<List<Book>> Get() =>
            // Aguarda até que GetAsync() do serviço de livros seja concluido 
            await _booksService.GetAsync(); // Retorna uma tarefa que quando concluida traz uma lista de livros

        // Recuperar os detalhes de livro com base no id
        [HttpGet("{id:length:(24)}")]
        public async Task<ActionResult<Book>> Get(string id)
        {
            var book = await _booksService.GetAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        // POST - Envia dados para o servidor
        [HttpPost]
        public async Task<IActionResult> Post(Book newBook) // IActionResult é uma interface
        {
            await _booksService.CreateAsync(newBook);

            // CreatedAtACtion é um método que ccria respostas com um código de status HTTP 201
            return CreatedAtAction(nameof(Get), new { id = newBook.Id}, newBook);
        }

        // Atualizar
        [HttpPut("{id:length:(24)}")]
        public async Task<IActionResult> Update(string id, Book updatedBook) // espera o Id do livro que será atualziado
        {
            // Busca o livro
            var book = await _booksService.GetAsync(id);
            if (book == null)
                return NotFound();
            updatedBook.Id = book.Id; // Atualiamos o Id do updatedBook com o Id do livro encontrado
            await _booksService.UpdateAsync(id, updatedBook);

            return NoContent(); // Após sucesso -> HTTP 204 No Content
        }
    }
}
