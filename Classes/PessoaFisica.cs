using cadastro.Interfaces;

namespace cadastro.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf { get; set; }
        public DateTime dataNasc { get; set; }



        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;

            }else if (rendimento > 1500 && rendimento <= 3500)
            {
               float percent = (rendimento / 100) * 2;   
               return percent;         

            }else if (rendimento > 3000 && rendimento <= 6000)
            {
                float percent = (rendimento / 100) * 3.5f;   
                return percent;                 

            }else
            {
                float percent = (rendimento / 100) * 5;   
                return percent;
            }
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