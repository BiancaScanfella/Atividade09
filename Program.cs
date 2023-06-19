using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09CursoSerasa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> produtos = new List<string> { "pepsi", "fanta" };
            Console.WriteLine("Bem-vindo ao Conradito Store");
            
            string upper;

            while (true)// fazer o codigo se repetir sem mostrar o 'cabeçalho'
            {
                Console.WriteLine("Digite 1 para cadastrar ou 2 para listar:");
                int respostas = int.Parse(Console.ReadLine());
                if (respostas == 1)
                {
                    Console.WriteLine("Digite o nome do produto:");
                    string produto = Console.ReadLine();
                    produto = (produto.ToLower());// serve para deixar tudo minusculo 
                    
                    


                    if (produtos.Contains(produto) )
                    {
                        Console.WriteLine("Esse produto já está na lista...");
                    }
                    else
                    {
                        produtos.Add(produto);
                        Console.WriteLine("Produto adicionado!");
                    }
                }
                else
                {

                    string texto = ""; // podemos manipular esse comando
                    int contador = 0;
                    while (contador < produtos.Count)
                    {
                        string nome = produtos[contador];
                        string primeira_letra = nome.Substring(0, 1).ToUpper();
                        string resto = nome.Substring(1, nome.Length - 1);
                        string nome_tratado = primeira_letra + resto;
                        // serve para deixar a primeira letra maiusccula
                       
                        texto += produtos[contador] + ", "; //como fazer para deixar tudo na mesma linha ex: fanta, coca...
                        contador++;
                    }

                     texto = texto.Substring(0, texto.Length-2);// serve para cortar alguma coisa da palavra
                    //|> seve para guardar a infomação 
                    Console.WriteLine(texto);


                }
            }
            


            
        }
    }
}
