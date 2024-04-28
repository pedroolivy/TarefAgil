using System.Text.Json.Serialization;
using TarefAgil.Dominio.Enumeradores;

namespace TarefAgil.Dominio.Modelos
{
    public class Tarefas
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public StatusEnum Status { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int UsuarioId { get; set; }
        [JsonIgnore]
        public Usuario? Usuario { get; set; }
    }
}
