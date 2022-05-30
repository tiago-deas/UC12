using cadastro.Interfaces;

namespace cadastro.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf { get; set; }
        public DateTime dataNasc { get; set; }



        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validarDataNasc(DateTime dataNsc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validarDataNasc(string dataNasc)
        {

            DateTime dataConvertida;

            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }                
            }

            return false;
            
        }
    }
}