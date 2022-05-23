// Desafios Inicias C# - GFT Start #5
// MAIOR E POSIÇÃO

//DESAFIO
//Você recebeu o desafio de ler 100 valores inteiros. 
//Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

//ENTRADA
//O arquivo de entrada contém 100 números inteiros, positivos e distintos.

//SAÍDA
//Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.


// Abaixo segue um exemplo de código que você pode ou não utilizar

using System; 

class TesteMaiorPosicao {

    static void Main(string[] args) { 
			
			//TODO: Complete os espaços em branco com uma possível solução para o desafio
            
			int n;
            int maior = 0;
            int posicao = 0;
            for(int i = 1; i <= 100 ; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if(n > maior)
                {
                    maior = n ;
                    posicao = i ;     
                } 
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
    }
}
