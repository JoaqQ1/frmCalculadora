using System;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {                 
            PrimerOperando = primerOperando;
            SegundoOperando = segundoOperando;                  
        }
        public Numeracion PrimerOperando{ get { return primerOperando;}set { primerOperando = value;}}
        public Numeracion SegundoOperando{ get { return segundoOperando;}set { segundoOperando = value;}}

      
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
