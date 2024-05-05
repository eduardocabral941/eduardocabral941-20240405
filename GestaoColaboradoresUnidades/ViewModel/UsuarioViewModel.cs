namespace GestaoColaboradoresUnidades.ViewModel
{
    public class UsuarioViewModel
    {
        /// <summary>
        ///  Login do usuário 
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Senha do usuário 
        /// </summary>
        public string Senha { get; set; }
        /// <summary>
        /// Status do usuário verificando se está ativo ou não
        /// </summary>
        public bool Status { get; set; }
    }
}
