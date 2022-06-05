using System.Text.RegularExpressions;
using cadastro.Interfaces;

namespace cadastro.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }     
        
        
        

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validarCnpj(string cnpj)
        {
           bool retornoCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)");
           
           if (retornoCnpjValido == true)
           {
              if (cnpj.Length == 18){

                  string subStringCnpj = cnpj.Substring(11, 4);

                  if (subStringCnpj == "0001"){
                      return true;
                  }

              }else if(cnpj.Length == 14){

                  string subStringCnpj = cnpj.Substring(8, 4);

                  if (subStringCnpj == "0001"){
                      return true;
                  }

              }
           }

           return false;
            
        }
    }
}