namespace ProEventos.API.Models
{
    public class Evento
    {
        public int id { get; set; }
        public string Local { get; set; }
        public string DetaEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemUrl { get; set; }
    }
}