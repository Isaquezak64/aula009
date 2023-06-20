using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula009EstoqueProdutosTerQui
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> produtos = new List<string>();

            Console.WriteLine("Bem-vindo ao Conradito Store");

            while (true)
            {
                Console.WriteLine("digite 1 para cadastrar ou 2 para listar ");
                string resposta = Console.ReadLine();
                //int resposta=int.Parse( console.readline());

                if (resposta == "1")
                {
                    Console.WriteLine("Digite o nome do produto:");
                    string produto = Console.ReadLine();
                    produto= produto.ToLower();
                    if (produto.Contains(produto))
                    {
                        Console.WriteLine("Esse item ja existe na lista...");
                    }

                    else
                    {
                        produtos.Add(produto);
                        Console.WriteLine("Produto adicionado!");
                    }

                }
                else {
                    string texto = "";
                    int contador = 0;
                    while (contador< produtos.Count) {

                          
                       string primeira_letra = texto.Substring(0. 1);
                        texto += produtos[contador] + ", ";
                        contador++;
                    }
                   
                    texto.Substring(0, texto.Length - 2 );

                    Console.WriteLine(texto);
                   
                
                }


                        






            }
        }
    }
}
