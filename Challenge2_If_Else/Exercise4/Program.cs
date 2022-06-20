using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicio < horaFinal)
            {
                duracao = horaFinal - horaInicio;
            }
            else
            {
                duracao = 24 - horaInicio + horaFinal;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}