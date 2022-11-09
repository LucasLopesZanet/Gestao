namespace Gestao.Web.Models
{
    public class Lancamento
    {
        public Lancamento()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public long Valor { get; set; }
    }
}
