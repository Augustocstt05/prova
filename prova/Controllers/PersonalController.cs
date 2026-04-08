using prova.Models;
using Microsoft.AspNetCore.Mvc;
using prova.Data;
using Microsoft.EntityFrameworkCore;



namespace prova.Controllers
{
    public class PersonalController : Controller
    {
        private readonly ApplicationDbContext _context;

        // O construtor recebe o contexto que connfigurei no program.cs
        public PersonalController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // Recupera a lista de pessoas do banco de dados
            var pessoas = _context.Personals.ToList();
            return View(pessoas);
        }


        // GET: Personal/Create
        // Essa ação apenas abre a tela com o formulário vazio
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personal/Create
        // Essa ação recebe o que o usuário digitou e salva no SQL Server
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonalID,Nome,Especialidade")] Personal personal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // Volta para a lista após salvar
            }
            return View(personal); // Se der erro, volta para a tela mostrando o que está errado
        }
    }
}
