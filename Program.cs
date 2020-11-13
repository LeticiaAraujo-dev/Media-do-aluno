using System;
//iniciar o c#: dotnet new console
//executar o c#: dotnet run
namespace Media_do_aluno
{
    class Program
    {
        static void Main(string[] args)
        {

            //entrada de informação
            string nomeCompleto;
            float nota1, nota2, nota3, media;

            Console.WriteLine("Digite o nome do aluno");
            nomeCompleto = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota:");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            nota3 = float.Parse(Console.ReadLine());

            //processamento
            media = (nota1 + nota2 + nota3)/3;

            //exibir resultados
            if(media>5){
                //valor verdadeiro
                Console.WriteLine("O aluno "+nomeCompleto+" está aprovado com a média de: "+media);
            }else{
                //valor falso
                Console.WriteLine("O aluno "+nomeCompleto+" está REPROVADO com a média de: "+media);
            }
        }
    }
}
