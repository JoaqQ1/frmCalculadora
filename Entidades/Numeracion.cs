using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{     
    public class Numeracion
    {
        private ESistemas Sistemas { get; set; }            
        
        private double valorNumerico;
        public string Valor{ get{ return this.valorNumerico.ToString(); } }

        public Numeracion(double valorNumerico, ESistemas sistemas):this(valorNumerico.ToString(), sistemas) { }                    
        
        public Numeracion(string valorNumerico, ESistemas sistemas)
        {
            InicializarValores(valorNumerico, sistemas);
        }
        
        private void InicializarValores(string valor, ESistemas sistema)
        {
            Sistemas = sistema;

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
            if (this != sistema)
            {
                switch (sistema)
                {
                    case ESistemas.Binario:
                        return DecimalABinario(Valor);
                    case ESistemas.Decimal:
                        return BinarioDecimal(Valor).ToString();
                    default:
                        return "";
                }
            }
            return Valor;
        }

        private bool EsBinario(string valorNumerico)
        {
            bool retorno = true;
            foreach (char c in valorNumerico)
            {
                if (c != '0' && c != '1')
                {
                    retorno = false;
                    break;
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
            if (double.TryParse(valor, out double valorNumerico) && valorNumerico > -1)
            {
                //valorNumerico = Math.Round(valorNumerico);
                int valorEntero = (int)valorNumerico;
                return DecimalABinario(valorEntero);
            }
            return "Numero invalido";
        }

        //Sobre carga de operadores ==
        public static bool operator == (Numeracion n1, Numeracion n2)
        {
            return n1.Sistemas == n2.Sistemas;
        }
        public static bool operator != (Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }
        public static bool operator == (Numeracion n,ESistemas s )
        {
            return n.Sistemas == s;
        }
        public static bool operator != (Numeracion n,ESistemas s)
        {
            return !(n == s);
        }
        public override bool Equals(object? obj)
        {
            if (obj is ESistemas s)
            {
                return this == s;
            }
            else if (obj is Numeracion n)
            {
                return this == n;
            }
            else
            {
                return false;

            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //Sobre carga de operadores +/*-
        public static Numeracion operator + (Numeracion n1, Numeracion n2)
        {
            double resultado;
            string valor = "Numero Invalido";
            if (n1 == n2)
            {
                resultado = double.Parse(n1.ConvertirA(ESistemas.Decimal)) + double.Parse(n2.ConvertirA(ESistemas.Decimal));
                valor = resultado.ToString();
            }
            return new Numeracion(valor, n1.Sistemas);
        }
        public static Numeracion operator - (Numeracion n1, Numeracion n2)
        {
            double resultado;
            string valor = "Numero Invalido";
            if (n1 == n2)
            {
                resultado = double.Parse(n1.ConvertirA(ESistemas.Decimal)) - double.Parse(n2.ConvertirA(ESistemas.Decimal));
                valor = resultado.ToString();
            }
            return new Numeracion(valor, n1.Sistemas);
        }

        public static Numeracion operator * (Numeracion n1, Numeracion n2)
        {

            double resultado;
            string valor = "Numero Invalido";
            if (n1 == n2)
            {
                resultado = double.Parse(n1.ConvertirA(ESistemas.Decimal)) * double.Parse(n2.ConvertirA(ESistemas.Decimal));
                valor = resultado.ToString();
            }
            return new Numeracion(valor, n1.Sistemas);
        }

        public static Numeracion operator / (Numeracion n1, Numeracion n2)
        {            
            double resultado;
            string valor = "Numero invalido";
            if (n1 == n2 && n2.ConvertirA(ESistemas.Decimal) != "0")
            {
                resultado = double.Parse(n1.ConvertirA(ESistemas.Decimal)) / double.Parse(n2.ConvertirA(ESistemas.Decimal));
                valor = resultado.ToString();
            }      
            return new Numeracion(valor, n1.Sistemas);
        }
    }
    
}
