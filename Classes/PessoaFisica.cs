using cadastro.Interfaces;

namespace cadastro.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {
        public string? cpf {get; set;}
        public DateTime dataNasc { get; set; }
        
        
         
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validarDataNasc(DateTime dataNsc)
        {
            throw new NotImplementedException();
        }
    }
}