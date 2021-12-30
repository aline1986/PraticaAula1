using PraticaAula1.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//localização da classe no projeto
namespace PraticaAula1.Repositories
{ 
    //definição da classe
    public class FuncionarioRepository
    {    
        //Método para gravar os dados do cliente em um arquivo
        public void ExportarDados(Funcionario funcionario)
        {
            //Abrir arquivo em modo de escrita
            var streamWriter = new StreamWriter("c:\\temp\\funcionario.txt");

            //escrevendo os dados do cliente no arquivo
            Console.WriteLine("IdFuncionário...:" + funcionario.IdFuncionario); //fazer um tab
            Console.WriteLine("NOME...:" + funcionario.Nome);
            Console.WriteLine("CPF..:" + funcionario.Cpf);
            Console.WriteLine("MATRICULA...:" + funcionario.Matricula);
            Console.WriteLine("SALARIO...:" + funcionario.Salario);
            Console.WriteLine("CARGO...:" + funcionario.Cargo);
            Console.WriteLine("DATA DA ADMISSÃO...:" + funcionario.DataAdmissao);
            Console.WriteLine("........................");

            //Salvando e fechando o arquivo
            streamWriter.Flush();
            streamWriter.Close();

        }
    }
}
