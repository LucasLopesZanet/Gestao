using Gestao.Web.Models;
using Gestao.Web.Servico.Interface;

namespace Gestao.Web.Servico
{
    public class LancamentoService: ILancamentoService
    {
        List<Lancamento> baseDeDados = new List<Lancamento> 
        { 
            new Lancamento {Id = 1, Descricao = "Aluguel", Valor = 500 },
            new Lancamento {Id = 2, Descricao = "Carro", Valor = 1000 },
            new Lancamento {Id = 3, Descricao = "Cartão", Valor = 1500 },
            new Lancamento {Id = 4, Descricao = "Faculdade", Valor = 800 },
            new Lancamento {Id = 5, Descricao = "Internet", Valor = 150 },
            new Lancamento {Id = 6, Descricao = "Energia", Valor = 500 },
        };
        public List<Lancamento> BuscarTodosLancamentos()
        {
            return baseDeDados;
        }
        public List<Lancamento> BuscarPorValor(long valor)
        {
            var lancamentoNaBase = baseDeDados.Where(x => x.Valor == valor).ToList();
            return lancamentoNaBase;
        }
        public List<Lancamento> BuscarPorDescricao(string descricao)
        {
            var lancamentoNaBase = baseDeDados.Where(x => x.Descricao == descricao).ToList();
            return lancamentoNaBase;
        }
        public Lancamento BuscarPorId(long Id)
        {
            var lancamentoNaBase = baseDeDados.FirstOrDefault(x => x.Id == Id);
            return lancamentoNaBase;
        }

        public Lancamento Editar(Lancamento lancamento )
        {
            var lancamentoNaBase = baseDeDados.FirstOrDefault(x => x.Id == lancamento.Id);
            lancamentoNaBase.Descricao = lancamento.Descricao;
            lancamentoNaBase.Valor = lancamento.Valor;
            
            return lancamentoNaBase;
        }
        public Lancamento Excluir(long Id)
        {
            var lancamentoNaBase = baseDeDados.FirstOrDefault(x => x.Id == Id);
            baseDeDados.Remove(lancamentoNaBase);        
            return lancamentoNaBase;
        }
        public Lancamento AdicionaLancamento(Lancamento lancamento)
        {
            baseDeDados.Add(lancamento);
            return lancamento;
        }
    }
}
