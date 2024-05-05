using System.ComponentModel.DataAnnotations;

namespace GestaoColaboradoresUnidades.Model
{
    public class Usuario
    {
        [Key]
        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public bool Status { get; private set; }

        public Usuario(string login, string senha, bool status)
        {
            this.Login = login;
            this.Senha = senha;
            this.Status = true;
        }

        public void AlterarSenha(string senha)
        {
            this.Senha = senha;
        }

        public void AlterarStatus(bool status)
        {
            this.Status = status;
        }
    }
}
