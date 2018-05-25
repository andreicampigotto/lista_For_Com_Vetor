using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exercicio07
    {
        public Exercicio07()
        {
            string[] caracteres = new string[20];
            string[] especiaisCaracteres = new string[caracteres.Length];
            string[] consoantes = new string[caracteres.Length];
            string[] vogais = new string[caracteres.Length];
            int qtdaVogais = 0, qtdaConsoantes = 0, contador = 0;
            
            Console.Write("Digite uma frase: " +
                          "\nmáximo 20 caracteres");

            for (int i = 0; i < caracteres.Length; i++)
            {
                caracteres[i] = Console.ReadLine().ToUpper().Trim();
            }
            for (int i = 0; i < caracteres.Length; i++)
            {
                
            }

        }
    }
}
