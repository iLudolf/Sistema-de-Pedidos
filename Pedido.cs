using System;

namespace AOP02_Paloma.Pedido
{
 public class Pedidos{
            
        private int pedidoID = 0; 
        private DateTime dataEmissao = new DateTime();
        // private float dataEmissao = 0;  
        private float valorDoProduto = 0;  
        private string descricaoDoProduto = " ";

  public Pedidos(int pedidoid, DateTime dataemissao, float valordoproduto, string descricaodoproduto){
        this.pedidoID = pedidoid;
        this.dataEmissao = dataemissao;
        this.valorDoProduto = valordoproduto;
        this.descricaoDoProduto = descricaodoproduto;
    }

//   public void setPedidoID (int pedidoid) {
//         pedidoID = pedidoid;
//     }

   public int getPedidoID()
    {
        return pedidoID;
    }

     public void setDataEmissao (DateTime dataemissao) {
        dataEmissao = dataemissao;
    }

   public DateTime getDataEmissao()  {
        return dataEmissao;
    }

       public void setValorDoProduto (float valordoproduto) {
        valorDoProduto = valordoproduto;
    }

   public float getValorDoProduto()  {
        return valorDoProduto;
    }

      public void setDescricaoDoProduto (float valordoproduto) {
        valorDoProduto = valordoproduto;
    }

   public string getDescricaoDoProduto()  {
        return descricaoDoProduto;
    }



    public float calcularPrecoTotal(){       
       
            return this.valorDoProduto;     
    }

    }    //Fim Class
}