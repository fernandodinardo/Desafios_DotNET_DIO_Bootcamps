// Desafios Inicias C# - GFT Start #5
// MÉDIA 2

//DESAFIO
//Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. 
//A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. 
//Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

//ENTRADA
//O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

//SAÍDA
//Imprima a variável MEDIA conforme exemplo abaixo, com 1 dígito após o ponto decimal 
//e com um espaço em branco antes e depois da igualdade. 
//Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, 
//caso contrário, você receberá "Presentation Error".


// Abaixo segue um exemplo de código que você pode ou não utilizar

using System;

namespace Media2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;
            //Console.WriteLine("Digite as notas:");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
			
			//TODO: Complete os espaços em branco com uma possível solução para o desafio
            
			Console.WriteLine();
            A = A * 2;
            B = B * 3;
            C = C * 5;
            MEDIA = (A+B+C)/10;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1")," ");
            Console.ReadKey();
        }
    }
}
