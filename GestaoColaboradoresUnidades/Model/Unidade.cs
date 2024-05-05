namespace GestaoColaboradoresUnidades.Model
{
    public class Unidade
    {
        public int Id { get; set; }
        public int CodigoUnidade { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }

        public void UpdateStatus(bool status)
        {
            Status = status;
        }   

        public  List<Colaborador> Colaboradores { get; set; }

        public Unidade(int codigoUnidade, string nome, bool status)
        {   CodigoUnidade = codigoUnidade;
            Nome = nome;
            Status = status;
        }
    }
}
