using System.Text.RegularExpressions;
using cadastro.Interfaces;

namespace cadastro.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }     
        
        public string caminho {get; private set;} = "Database/PessoaJuridica.csv";
        


        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
               return rendimento * 0.03f;

            }else if (rendimento <= 6000)
            {
                 return rendimento * 0.05f;

            }else if(rendimento <= 10000)
            {
                 return rendimento * 0.07f;

            }else
            {
                 return rendimento * 0.09f;

            }
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

        public void Inserir(PessoaJuridica pj){
            
            Utils.VerificarPastaArquivo(caminho);

            string[] pjStrings = {$"{pj.nome},{pj.razaoSocial},{pj.cnpj},{pj.endereco.logradouro},{pj.endereco.numero},{pj.endereco.complemento},{pj.endereco.endComercial},{pj.rendimento}"};

            File.AppendAllLines(caminho, pjStrings);
        }

        public List<PessoaJuridica> LerArquivo(){

            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.nome = atributos[0];
                cadaPj.razaoSocial = atributos[1];
                cadaPj.cnpj = atributos[2];
                // cadaPj.endereco.logradouro[3];
                // cadaPj.endereco.numero = atributos[3];
                cadaPj.endereco.complemento = atributos[4]; 
                // cadaPj.endereco.endComercial = atributos[5];
                // cadaPj.rendimento = atributos[6];          
                               
                

                listaPj.Add(cadaPj);
            }

            return listaPj;
        }
    }
}