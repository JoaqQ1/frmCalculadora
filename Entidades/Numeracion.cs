using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public enum ESistemas
    {
        Binario,
        Decimal
    }
    public class Numeracion
    {
        private ESistemas sistemas;
        private double valorNumerico;

        public Numeracion(double valorNumerico, ESistemas sistemas)
        {
            InicializarValores(valorNumerico.ToString(), sistemas);
        }
        public Numeracion(string valorNumerico, ESistemas sistemas)
        {
            InicializarValores(valorNumerico, sistemas);
        }

        public ESistemas Sistemas
        {
            get 
            { 
                return this.sistemas; 
            }
        }

        public string Valor
        {
            get
            {
                return this.valorNumerico.ToString();
            }
        }

        private void InicializarValores(string valor, ESistemas sistema)
        {

            this.sistemas = sistema;

            if (Sistemas == ESistemas.Binario && !(double.TryParse(valor, out this.valorNumerico)))
            {               
                this.valorNumerico = double.Parse(this.ConvertirA(ESistemas.Decimal));
            }
            else if (!(double.TryParse(valor, out this.valorNumerico)))
            {
                this.valorNumerico = double.MinValue;
            }
        }

        public string ConvertirA(ESistemas sistema)
        {
            if (sistema != this)
            {                
                switch (sistema)
                {
                    case ESistemas.Binario:
                        return DecimalABinario(Valor);
                    case ESistemas.Decimal:
                        return BinarioDecimal(Valor).ToString();                    
                }
            }

            return Valor;
        }

        private bool EsBinario(string valorNumerico)
        {
            bool retorno = true;
            foreach (char c in valorNumerico)
            {
                if ((c != '0') || (c != '1'))
                {
                    retorno = false;
                }
            }

            return retorno;
        }
        private double BinarioDecimal(string valor)
        {
            if (EsBinario(valor))
            {
                double decimalResult = 0;
                double binaryBase = 1;

                for (int i = valor.Length - 1; i >= 0; i--)
                {
                    if (valor[i] == '1')
                    {
                        decimalResult += binaryBase;
                    }

                    binaryBase *= 2;
                }
                return decimalResult;
            }
            double valorNum = double.Parse(valor);
            return valorNum;
        }

        private string DecimalABinario(int valor)
        {
            if (valor == 0)
            {
                return "0";
            }

            string binary = "";
            while (valor > 0)
            {
                double remainder = valor % 2;
                binary = remainder + binary;
                valor /= 2;
            }
            if (double.TryParse(binary, out double valorNumerico))
                return binary;
            else
                return "Numero invalido";
        }



        private string DecimalABinario(string valor)
        {
            if (double.TryParse(valor, out double valorNumerico) && valorNumerico > 0)
            {
                valorNumerico = Math.Round(valorNumerico);
                int valorEntero = (int)valorNumerico;
                return DecimalABinario(valorEntero);
            }
            return "Numero invalido";
        }

        public static bool operator == (Numeracion n1, Numeracion n2)
        {
            return n1.Sistemas == n2.Sistemas;
        }
        public static bool operator != (Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }
        public static bool operator == (ESistemas s, Numeracion n)
        {
            return s == n.Sistemas;
        }
        public static bool operator != (ESistemas s, Numeracion n)
        {
            return !(s == n);
        }

        public static Numeracion operator + (Numeracion n1, Numeracion n2)
        {
            double resultado;
            ESistemas nuevoSistema = ESistemas.Decimal;
            if (n1== n2)
            {
                resultado = double.Parse(n1.ConvertirA(ESistemas.Decimal)) + double.Parse(n2.ConvertirA(ESistemas.Decimal));           
            }
            else
            {
                resultado = -1;
                nuevoSistema = ESistemas.Binario;
            }
            Numeracion numAux = new Numeracion(resultado, nuevoSistema);
            return numAux;
        }
        public static Numeracion operator - (Numeracion n1, Numeracion n2)
        {
            double resultado = double.Parse(n1.ConvertirA(ESistemas.Decimal)) - double.Parse(n2.ConvertirA(ESistemas.Decimal));
            Numeracion numAux = new Numeracion(resultado, ESistemas.Decimal);
            return numAux;
        }
        public static Numeracion operator * (Numeracion n1, Numeracion n2)
        {

            double resultado = double.Parse(n1.ConvertirA(ESistemas.Decimal)) * double.Parse(n2.ConvertirA(ESistemas.Decimal));
            Numeracion numAux = new Numeracion(resultado, ESistemas.Decimal);
            return numAux;
        }
        public static Numeracion operator / (Numeracion n1, Numeracion n2)
        {
            
            double resultado;
            if (double.Parse(n2.ConvertirA(ESistemas.Decimal)) == 0)
            {
                resultado = 0;
            }
            else
            {
                resultado = double.Parse(n1.ConvertirA(ESistemas.Decimal)) / double.Parse(n2.ConvertirA(ESistemas.Decimal));
            }
            Numeracion numAux = new Numeracion(resultado, ESistemas.Decimal);
            return numAux;
        }


    }
}
