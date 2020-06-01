using System;

class MasterCard : Cartao
{
  // atributos

  public int parcelas { get; set; }

  public float desconto;

  //metodos

  public void ComparaComDescontoMastercard(float desconto)
  {
      Console.WriteLine(" Compra realizada em  " + parcelas + " parcelas e desconto de " + desconto + " reais " );
  }
}