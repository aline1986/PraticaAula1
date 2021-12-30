using PraticaAula1.Entities;
using PraticaAula1.Repositories;
using System;


//Define alocalização da classe dentro do projeto
namespace PraticaAula1
{
    //Definição daclasse
    class Program
    {
        //Método (funções) para executar o projeto
        static void Main(string[] args)

        {       // variavel    Inicializando variável para acessar os atributos(propriedades) da classe no caso funcionario 
            var funcionario = new Funcionario();

            //acessando propriedades da classe = atribuindo valor nas propriedades{set}
            funcionario.IdFuncionario =  Guid.NewGuid();

            Console.WriteLine("\n***Exerício 01-WebDeveloper****\n ");

            Console.Write("Informe o nome do funcionário:");
            funcionario.Nome = Console.ReadLine();   //ler o que usuario preencheu e depois de dar enter

            Console.Write("Informe o nome do Cpf do funcionário:");
            funcionario.Cpf = Console.ReadLine();

            Console.Write("Informe a matrícula do funcionário:");
            funcionario.Matricula = Console.ReadLine();

            Console.Write("Informe salário do funcionário:"); 
            funcionario.Salario = decimal.Parse(Console.ReadLine());


            Console.Write("Informe data de admissão do funcionário:");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            funcionario.DataAdmissao = dateTime;

            
            Console.Write("Informe cargo do funcionário:");
            funcionario.Cargo = Console.ReadLine();

            //imprimindo dados do cliente no console{get}
            Console.WriteLine("\nDADOS DO FUNCIONÁRIO:\n"); //\n Quebrar linha
            Console.WriteLine("IdFuncionário...:"+ funcionario.IdFuncionario); //fazer um tab
            Console.WriteLine("NOME...:" + funcionario.Nome );
            Console.WriteLine("CPF..:" + funcionario.Cpf);
            Console.WriteLine("MATRICULA...:" + funcionario.Matricula);
            Console.WriteLine("SALARIO...:"+ funcionario.Salario);
            Console.WriteLine("CARGO...:" + funcionario.Cargo);
            Console.WriteLine("DATA DA ADMISSÃO...:" + funcionario.DataAdmissao);

            
            try //tentativa de fazer algo
            {
                //Criando variável de instância
                var funcionarioRepository = new FuncionarioRepository();  //Chamar o codigo
           
            //executando a gravação do arquivo
            
            funcionarioRepository.ExportarDados(funcionario);

                Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!!");

            }
            catch (Exception e)  //Caputurar erro e traçar plano b
            {
                Console.WriteLine("\nOcorreu um erro!!! ");
                
            }
               //pausa a execução do prompt
               Console.ReadKey();
        }        
    }
}
