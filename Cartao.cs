using System;

class Cartao
{
    //atributos
    public string numero { get; set; }

    public string bandeira { get; set; }

     private string token {get;set;}

     protected int cvc {get;set;}


     //metodos

     public void aprovarCompra()
     {
         Console.WriteLine("Compra aprovada !");
     }

     private bool validarToken()
     {
         return  true;
     }

     protected bool validarCompra()
     {
         return true;
     }
}