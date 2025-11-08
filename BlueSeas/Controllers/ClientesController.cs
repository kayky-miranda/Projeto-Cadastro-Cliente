using BlueSeas.Data;
using Microsoft.AspNetCore.Mvc;
using BlueSeas.Models;

namespace BlueSeas.Controllers
{
    public class ClientesController : Controller
    {

        readonly private ApplicationDbContext _db;


        public ClientesController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<CadastrosModel> cadastros = _db.Cadastros;
            return View(cadastros);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            CadastrosModel cadastros = _db.Cadastros.FirstOrDefault(x => x.Id == id);

            if (cadastros == null)
            {
                return NotFound();
            }

            return View(cadastros);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            CadastrosModel cadastros = _db.Cadastros.FirstOrDefault(x => x.Id == id);

            if (cadastros == null)
            {
                return NotFound();
            }

            return View(cadastros);
        }


        [HttpPost]
        public IActionResult Cadastrar(CadastrosModel cadastros)
        {
            if(ModelState.IsValid)
            {

                _db.Cadastros.Add(cadastros);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";

                return RedirectToAction("Index");
            }

            TempData["MensagemErro"] = "Ocorreu algum erro durante o cadastro!";
            return View();
        }

        [HttpPost]
        public IActionResult Editar(CadastrosModel cadastros)
        { 
            if(ModelState.IsValid)
            {
                _db.Cadastros.Update(cadastros);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Edição realizada com sucesso!";

                return RedirectToAction("Index");
            }
            TempData["MensagemErro"] = "Ocorreu algum erro durante a edição!";
            return View(cadastros);

        }

        [HttpPost]
        public IActionResult Excluir(CadastrosModel cadastros)
        {
            if (cadastros == null)
            {
                return NotFound();
            }

            _db.Cadastros.Remove(cadastros);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Remoção realizada com sucesso!";

            return RedirectToAction("Index");

        }
    }



}
