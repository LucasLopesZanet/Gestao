using Gestao.Web.Models;
using Gestao.Web.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;

namespace Gestao.Web.Repositorio
{
    public class LancamentoRepositorio : ILancamentoRepositorio
    {
        public Contexto _context; 
        internal DbSet<Lancamento> _dbSet;
        public LancamentoRepositorio(Contexto contexto)
        {
            _context = contexto;
            _dbSet  = _context.Set<Lancamento>();
        }

        public Lancamento AdicionaLancamento(Lancamento lancamento)
        {
            _dbSet.Add(lancamento);
            _context.SaveChanges();
            return lancamento;
        }

        public List<Lancamento> BuscarPorDescricao(string descricao)
        {
            var lancamentosNaBase = _dbSet.Where(x=>x.Descricao == descricao);
            return lancamentosNaBase.ToList();
        }

        public Lancamento BuscarPorId(long Id)
        {
            var lancamentoNaBase = _dbSet.FirstOrDefault(x=>x.Id== Id);
            return lancamentoNaBase;
        }

        public List<Lancamento> BuscarPorValor(long valor)
        {
            var lancamentosNaBase = _dbSet.Where(x => x.Valor == valor);
            return lancamentosNaBase.ToList();
        }

        public List<Lancamento> BuscarTodosLancamentos()
        {
            var lancamentosNaBase = _dbSet.ToList();
            return lancamentosNaBase;
        }

        public Lancamento Editar(Lancamento lancamento)
        {
            var lancamentoNaBase = _dbSet.FirstOrDefault(x => x.Id == lancamento.Id);
            lancamentoNaBase.Descricao = lancamento.Descricao;
            lancamentoNaBase.Valor= lancamento.Valor;
            _dbSet.Update(lancamentoNaBase);
            _context.SaveChanges();
            return lancamentoNaBase;
        }

        public Lancamento Excluir(long Id)
        {
            var lancamentoNaBase = _dbSet.FirstOrDefault(x => x.Id == Id);
            _dbSet.Remove(lancamentoNaBase);
            _context.SaveChanges();
            return lancamentoNaBase;
        }

        

    }
}
