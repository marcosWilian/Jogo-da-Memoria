using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp1
{
    public static class VerificadorNumeros
    {
        private static int [] vetor = new int[17];

        private static int i = 1;


        public  static void criarVetor()
        {
            int numero = 0, contador = 1, verif=0, x = 0;
            while(contador <= 16)
            {
                //recebeu numero
                numero = sortear(); // 15
                verif = verificar(numero);

                if(contador <= 8)
                {
                    x = vetor[contador - 1];
                    if (x != numero)
                    {
                        if (verif == 0)
                        {
                            vetor[contador] = numero;
                            contador++;
                        }
                    }
                }
                if (contador > 8)
                {
                    x = vetor[contador - 1];
                    if (x != numero)
                    {
                        if (verif == 1)
                        {
                            vetor[contador] = numero;
                            contador++;
                        }
                    }
                }
                
            }
           
        }

        public static int getNumero()
        {
            int num;
            num = vetor[i];
            i++;
            return num;
        }

        private static int verificar(int numero)
        {
            int verificar = 0;
            for (int i = 0; i < 16; i++)
            {
                if (numero == vetor[i])
                {
                    verificar = verificar + 1; // Aumenta um número no indice para checagem
                }

            }

            return verificar;
        }

        private static int sortear()
        {
            Random rn = new Random();
            return rn.Next(1,16);
        }
    }
}
