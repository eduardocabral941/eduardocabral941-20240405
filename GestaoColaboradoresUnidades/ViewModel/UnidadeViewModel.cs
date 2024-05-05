namespace GestaoColaboradoresUnidades.ViewModel
{
    public class UnidadeViewModel
    {   /// <summary>
        /// Código da unidade em que o colaborador está alocado
        /// </summary>
        public int CodigoUnidade { get; set; }
        /// <summary>
        /// Nome da unidade em que o colaborador está alocado
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Status da unidade se está ativa ou não
        /// </summary>
        public bool Status { get; set; }
    }
}