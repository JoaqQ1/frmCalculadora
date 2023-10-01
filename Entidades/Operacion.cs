using System;

namespace Entidades
{
    public class Operacion
    {

        public Numeracion PrimerOperando { get; set; }
        public Numeracion SegundoOperando { get; set; }

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {                 
            PrimerOperando = primerOperando;
            SegundoOperando = segundoOperando;                  
        }      
      
        public Numeracion Operar(char operador)
        {
            Numeracion resultado;
            switch(operador)
            {
                case '+':
                    resultado = PrimerOperando + SegundoOperando;
                    break;
                case '-':
                    resultado = PrimerOperando - SegundoOperando;
                    break;
                case '*':
                    resultado = PrimerOperando * SegundoOperando;
                    break;
                case '/':
                    resultado = PrimerOperando / SegundoOperando;
                    break;
                default:
                    resultado = PrimerOperando + SegundoOperando;
                    break;

            }
            return resultado;
        }  

    }
}
