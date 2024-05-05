using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoColaboradoresUnidades.Model
{ 
    public class Colaborador
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        [ForeignKey("Unidade")]
        public int UnidadeId { get; set; }

        [ForeignKey("Usuario")]
        public int UserId { get; set; }


        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarUnidade(int unidadeId)
        {
            UnidadeId = unidadeId;
        }

        public Colaborador(string nome, int unidadeId, int userId)
        {
            Nome = nome;
            UnidadeId = unidadeId;
            UserId = userId;
        }
    }
}
