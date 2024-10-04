using System;

namespace BancoDigital
{
    public class ConversorMoeda
    {
        
        public double QuantReal { get; set; }
        public double Dolar { get; set; }
        public double ValorReal { get; private set; }

        
        public double Conversor()
        {
            
            double IOF = (QuantReal * Dolar * 6) / 100;

            
            ValorReal = QuantReal * Dolar + IOF;
            return ValorReal;
        }

       
        public override string ToString()
        {
            return $"Valor a ser pago em reais: {Conversor():F2}";
        }
    }
}