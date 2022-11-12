using Gestao.Web.Models;
using Gestao.Web.Repositorio;
using Gestao.Web.Repositorio.Interface;
using Gestao.Web.Servico.Interface;

namespace Gestao.Web.Servico
{
    public class LancamentoService: ILancamentoService
    {
      

        private readonly ILancamentoRepositorio _lancamentoRepositorio;
        public LancamentoService(ILancamentoRepositorio lancamentoRepositorio )
        {
            _lancamentoRepositorio= lancamentoRepositorio;
        }
        public List<Lancamento> BuscarTodosLancamentos( )
        {
            return _lancamentoRepositorio.BuscarTodosLancamentos();
        }
        public List<Lancamento> BuscarPorValor(long valor)
        {
            var lancamentoNaBase = _lancamentoRepositorio.BuscarPorValor(valor);
            return lancamentoNaBase;
        }
        public List<Lancamento> BuscarPorDescricao(string descricao)
        {
            var lancamentoNaBase = _lancamentoRepositorio.BuscarPorDescricao(descricao);
            return lancamentoNaBase;
        }
        public Lancamento BuscarPorId(long Id)
        {
            var lancamentoNaBase = _lancamentoRepositorio.BuscarPorId(Id);
            return lancamentoNaBase;
        }

        public Lancamento Editar(Lancamento lancamento )
        {
            
            return _lancamentoRepositorio.Editar(lancamento);
        }
        public Lancamento Excluir(long Id)
        {
            
            return _lancamentoRepositorio.Excluir(Id);
        }
        public Lancamento AdicionaLancamento(Lancamento lancamento)
        {
            _lancamentoRepositorio.AdicionaLancamento(lancamento);
            return lancamento;
        }
    }
}
