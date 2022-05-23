// Desafios Intermediários C# - GFT Start #5
// PINK E O CÉREBRO

//DESAFIO
//Pink e Cérebro dividem um apartamento e estão juntos 24h por dia desde o começo da pandemia. 
//Para passar o temp, Pink cria problemas matemáticos para Cérebro resolver, 
//o último deles foi uma lista de números com a seguinte pergunta: quantos números da lista são múltiplos de 2, 3, 4 e 5?

//Apesar de parecer simples, porém, quando a lista contém muitos números, 
//Cérebro se confunde e acaba errando alguns cálculos.

//Ajude Cérebro a resolver o desadio de Pink.

//ENTRADA
//A primeira linha da entrada consiste em um inteiro N (1 ≤ N ≤1000), representando a quantidade de números na lista de Pink.
//A segunda linha contém N inteiros Li (1 ≤ Li ≤ 100), representando os números da lista de Pink.

//SAÍDA
//Imprima a quantidade de números múltiplos de 2, 3, 4 e 5 presentes na lista. 
//Observe a formatação da saída nos exemplos, pois ela deve ser seguida rigorosamente.


//Abaixo segue um exemplo de código que você pode ou não utilizar

using System;

namespace PinkeCerebro
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()),
                num, 
                cont2 = 0, 
                cont3 = 0, 
                cont4 = 0, 
                cont5 = 0;
      
            string[] numString = Console.ReadLine().Split();
      
            for (int i = 0; i < n; i++) {
                num = int.Parse(numString[i]);
          
                if (num % 2 == 0) {
                    cont2++;
                }
                
                if (num % 3 == 0) {
                    cont3++;
                }
                
                if (num % 4 == 0) {
                    cont4++;
                }
                
                if (num % 5 == 0) {
                    cont5++;
                }
            }
      
            Console.WriteLine($"{cont2} Multiplo(s) de 2\n" +
                                $"{cont3} Multiplo(s) de 3\n" +
                                $"{cont4} Multiplo(s) de 4\n" +
                                $"{cont5} Multiplo(s) de 5");
        }
    }
}
