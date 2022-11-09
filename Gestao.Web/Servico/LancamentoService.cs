using Gestao.Web.Models;

namespace Gestao.Web.Servico
{
    public class LancamentoService
    {
        List<Lancamento> baseDeDados = new List<Lancamento> 
        { 
            new Lancamento { Descricao = "Aluguel", Valor = 500 },
            new Lancamento {Descricao = "Carro", Valor = 1000 },
            new Lancamento {Descricao = "Cartão", Valor = 1500 },
            new Lancamento {Descricao = "Faculdade", Valor = 800 },
            new Lancamento {Descricao = "Internet", Valor = 150 },
            new Lancamento {Descricao = "Energia", Valor = 500 },
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
    }
}
