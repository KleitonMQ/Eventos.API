namespace Eventos.API.Entities
{
    public class Evento
    {
        public Evento(int id, string titulo, string descricao, DateTime? dataInicio, DateTime? dataFim, string organizador)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            DataCriacao = DateTime.Now;
            Organizador = organizador;
        }

        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime? DataInicio { get; private set; }
        public DateTime? DataFim {  get; private set; }
        public DateTime? DataCriacao { get; private set; }
        public string Organizador { get; private set; }

    }
}
