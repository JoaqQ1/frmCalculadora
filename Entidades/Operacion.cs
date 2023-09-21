using System;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            try
            {              
                PrimerOperando = primerOperando;
                SegundoOperando = segundoOperando;
            }
            catch (Exception ex)
            {
                // Manejar la excepci�n aqu�
                Console.WriteLine($"Se ha producido una excepci�n: {ex.Message}");
            }
            
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
        }  /**/

    }
}
