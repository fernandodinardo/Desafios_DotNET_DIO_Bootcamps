// Desafios Inicias C# - GFT Start #5
// POLIGONOS REGULARES SIMPLES

//DESAFIO
//Na geometria Euclidiana, um polígono regular é um polígono em que todos os ângulos são iguais 
//e todos os lados tem o mesmo comprimento. Um polígono simples é aquele cujos segmentos de reta não se interceptam. 
//Abaixo pode-se ver vários mosaicos feitos por polígonos regulares.

//Você deve escrever um programa que, dados o número e o comprimento dos lados de um polígono regular, mostre seu perímetro.

//ENTRADA
//A entrada tem dois inteiros positivos: N e L, que são, respectivamente, o número de lados e o comprimento de cada lado de um polígono regular (3 ≤ N ≤ 1000000 and 1 ≤ L ≤ 4000).

//SAÍDA
//A saída é o perímetro P do polígono regular em uma única linha.


// Abaixo segue um exemplo de código que você pode ou não utilizar

using System; 

class Problem {

    static void Main(string[] args) {
	
		//TODO: Complete os espaços em branco com uma possível solução para o desafio
		
        string[] v = Console.ReadLine().Split();
        Console.WriteLine(int.Parse(v[0]) * int.Parse(v[1]));
    }
}
