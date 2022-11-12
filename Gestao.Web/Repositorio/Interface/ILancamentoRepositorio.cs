using Gestao.Web.Models;

namespace Gestao.Web.Repositorio.Interface
{
    public interface ILancamentoRepositorio
    {
        public List<Lancamento> BuscarTodosLancamentos();
        public List<Lancamento> BuscarPorValor(long valor);
        public List<Lancamento> BuscarPorDescricao(string descricao);
        public Lancamento BuscarPorId(long Id);

        public Lancamento Editar(Lancamento lancamento);
        public Lancamento Excluir(long Id);
        public Lancamento AdicionaLancamento(Lancamento lancamento);
    }
}
