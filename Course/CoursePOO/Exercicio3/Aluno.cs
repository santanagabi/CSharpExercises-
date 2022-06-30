using System;

namespace Exercicio3
{
    class Aluno
    {
        public string Nome;
        public double n1, n2, n3;

        public double NotaFinal()
        {
            return n1 + n2 + n3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public double NotaRestante()
        {
            if(Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }

    }
}
