using System;

namespace Aula07Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao x = new Cartao();
            x.aprovarCompra();

            MasterCard y = new MasterCard();
            y.parcelas = 5;
            y.ComparaComDescontoMastercard (35f);
        
        }
    }
}
