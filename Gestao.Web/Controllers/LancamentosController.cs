using Gestao.Web.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gestao.Web.Controllers
{
    public class LancamentosController : Controller
    {

        // GET: LancamentoController
        [HttpGet, Route("index")]
        public ActionResult Index()
        {
            LancamentoService _lancamentosService = new LancamentoService();
            ViewBag.Lancamentos = _lancamentosService.BuscarTodosLancamentos();

            return View();
        }
        public ActionResult Index(long valor)
        {
            LancamentoService _lancamentosService = new LancamentoService();
            ViewBag.Lancamentos = _lancamentosService.BuscarPorValor(valor);

            return View();
        }

        // GET: LancamentoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LancamentoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LancamentoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LancamentoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LancamentoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LancamentoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LancamentoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
