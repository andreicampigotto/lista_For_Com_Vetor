using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaForVetor
{
    class Exercicio10
    {
        public Exercicio10()
        {
            int maxNomes = 3,comA = 0, comS=0, silva = 0;
            string[] nomes = new string[maxNomes];
            string namesString = "";
            
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite o nome: ");
                nomes[i] = Console.ReadLine().ToUpper();
                
                if (nomes[i] == "S")
                {
                    comS++;
                }
                if (nomes[i] == "A")
                {
                    comA++;
                }
                if (nomes[i] == "SILVA")
                {
                    silva++;
                }
               
            }
            namesString = string.Join(" , ", nomes);
            Console.WriteLine(namesString);

        }
    }
}
