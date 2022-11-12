using Gestao.Web.Models;
using Gestao.Web.Servico;
using Gestao.Web.Servico.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gestao.Web.Controllers
{
    public class LancamentosController : Controller
    {
        private ILancamentoService _lancamentosService ;
        public LancamentosController(ILancamentoService lancamentosService)
        {
            _lancamentosService = lancamentosService;
        }


        // GET: LancamentoController
        [HttpGet, Route("index")]
        public ActionResult Index()
        {
            ViewBag.Lancamentos = _lancamentosService.BuscarTodosLancamentos();

            return View(_lancamentosService.BuscarTodosLancamentos());
        }
        public ActionResult Index(long valor)
        {
            ViewBag.Lancamentos = _lancamentosService.BuscarPorValor(valor);

            return View();
        }

        // GET: LancamentoController/Details/5
        public ActionResult Details(long id)
        {
            Lancamento lancamento = _lancamentosService.BuscarPorId(id);
            return View(lancamento);
        }

        // GET: LancamentoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LancamentoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Lancamento lancamento)
        {            
            try
            {
                _lancamentosService.AdicionaLancamento(lancamento);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LancamentoController/Edit/5
        public ActionResult Edit(long id)
        {
            Lancamento lancamento = _lancamentosService.BuscarPorId(id);
            return View(lancamento);
        }

        // POST: LancamentoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Lancamento lancamento)
        {
            try
            {
                _lancamentosService.Editar(lancamento);
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
            Lancamento lancamento = _lancamentosService.BuscarPorId(id);
            return View(lancamento);
        }

        // POST: LancamentoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _lancamentosService.Excluir(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
