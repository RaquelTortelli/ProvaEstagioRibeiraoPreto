using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio
{
    internal class Prova
    {   public void questao2()
        {
            int numeroInformado = 21;
            
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int proximoNumero;

            if (numeroInformado == 0 || numeroInformado == 1)
            {
                Console.WriteLine("Pertence a sequência Fibonacci");
                return;
            }
            
            for (int i = 0; i <= numeroInformado; i++)
            {
                proximoNumero = numeroAnterior + numeroAtual;
                numeroAnterior = numeroAtual;
                numeroAtual = proximoNumero;

                if (numeroInformado == numeroAtual)
                {
                    Console.WriteLine("Pertence a sequência Fibonacci");
                    return;
                }
            }

            Console.WriteLine("Não pertence a sequência Fibonacci");
        }

        public void questao5()
        {
            string stringInformada = "Teste de reversão de string";
            string stringInvertida = "";

            for (int i = stringInformada.Length - 1; i >= 0; i--)
            {
                stringInvertida = stringInvertida + stringInformada[i].ToString();
            }

            Console.WriteLine(stringInvertida);
        }
    }
}
