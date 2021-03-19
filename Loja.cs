using System;
using System.Collections.Generic;
using  System.Runtime.InteropServices; 
using AOP02_Paloma.Pedido;


namespace AOP02_Paloma{
    
class Loja{
  static List<Pedidos> listaPedidos = new List<Pedidos>();   
  
static void Main(string[] args){
            
    
        
 // Mensagem de apresentação
 Console.WriteLine("\n ##############################################################\n"+
                      "#                                                            #\n"+     
                      "#               Atividade Avaliativa – AOP02                 #\n"+
                      "#             Atividade 01. Sistema de Pedidos               #\n"+
                      "#                                                            #\n"+     
                      "##############################################################\n"+  
                      "#                                                            #\n"+     
                      "#                                         By: Paloma Viana   #\n"+
                      "#                                                            #\n"+  
                      "##############################################################\n\n"
                   );

               
                
           
                bool aux = true; 

    


while (aux) //Enquanto test for igual a true, faça isso: 
{ 
    // Console.Clear(); 
    Console.Write("\n###############################################################\n"+
                      "#                                                             #\n"+     
                      "#                   Sistema de Pedidos   V1                   #\n"+                      
                      "#                                                             #\n"+
                      "###############################################################\n"+
                      "#                                                             #\n"+ 
                      "#                   Insira a opção desejada                   #\n"+
                      "#                                                             #\n"+ 
                      "#  1 - Exibir todos os pedidos                                #\n"+   
                      "#  2 - Inserir Pedido                                         #\n"+  
                      "#  3 - Pesquisar pedido                                       #\n"+  
                      "#  4 - Excluir pedido                                         #\n"+ 
                      "#  5 - Alterar Pedido                                         #\n"+  
                      "#  6 - Sair                                                   #\n"+ 
                      "#                                                             #\n"+                 
                      "#                                  Data: "+dateAtual()+"           #\n"+   
                      "#                                                             #\n"+                    
                      "###############################################################\n\n"+

                      "=> "                    
                      
                   );    

                   
                int caseSwitch = Int32.Parse(Console.ReadLine()); 

//Estrura do Menu switch
    
      switch (caseSwitch){

          case 1:   // consultar Pedidos  
          
         //Verificar se a lista esta vazia
          if(listaPedidos.Count == 0){
               msgListVazia();
         } else {
       consultarPedidos();
    }         break;
          case 2:      
              inserirPedido();         
              break;
         case 3:  
               if(listaPedidos.Count == 0){
               msgListVazia();
          }else {
             buscarPedido(); }          
              break;
         case 4:   
         if(listaPedidos.Count == 0){
               msgListVazia();
          }else {
             excluirPedido(); }                               
              break;
          case 5:  
               if(listaPedidos.Count == 0){
               msgListVazia();
          }else {
             alterarPedido(); }   

          break;
          default:
               Console.Clear();
               Console.WriteLine("\n.\n");
               Console.WriteLine("\n##############################################################\n"+
                                   "#                                                            #\n"+     
                                   "#               Encerrando programa...                       #\n"+
                                   "#                                                            #\n"+     
                                   "##############################################################\n");  
              aux = false;
              break;
        }//Fim da Estrura do Menu switch

   
     }   //Fim do while
    
 
    
       
            
        }// Fim Main
static void consultarPedidos(){  
  
  foreach (Pedidos element in listaPedidos){
 
               Console.WriteLine("\n------------------------------------------------------------\n"+                                  
                                   "# Pedido nº: "+element.getPedidoID()+"                        \n"+                              
                                   "------------------------------------------------------------\n"+                                
                                   "# Data Emissão: "+element.getDataEmissao()+"                  \n"+
                                   "# Valor do Produto: "+element.getValorDoProduto()+"           \n"+
                                   "# Descriçao do Produto: "+element.getDescricaoDoProduto()+"   \n"+                               
                                   "------------------------------------------------------------\n");     


//   Console.WriteLine("\nID: "+element.getPedidoID());
//   Console.WriteLine("Data Emissão: "+element.getDataEmissao());
//   Console.WriteLine("Valor do Produto: "+element.getValorDoProduto());
//   Console.WriteLine("Descriçao do Produto: "+element.getDescricaoDoProduto()+"\n");

    }
    
           }  //Fim do metodo Consultar Pedidos

static void inserirPedido(){  
  
bool aux = true; 

//Laço para ir adicionando valores a List Collections
 while(aux){ 

 Console.WriteLine(" ");
 Console.Write("Informe o valor do produto: \n=> ");
 int valorDoProduto = Int32.Parse(Console.ReadLine()); 
 Console.Write(" ");

 Console.Write("Informe a descrição do produto: \n=> ");
 string descricaoDoProduto = Console.ReadLine();
 Console.Write(" ");
 
 Console.Write("\nDeseja adicionar mais pedidos?\n");
 Console.Write("Digite: [S] Sim ou [N] Não \n\n => ");
 string cont = Console.ReadLine();
 Console.Write(" ");

//Adicionar valores na lista: Criando o Objeto Pedidos com os dados informados
listaPedidos.Add(new Pedidos(createID(),DateTime.Now,valorDoProduto,descricaoDoProduto) );
consultarPedidos(); 

if(cont.Equals("n") || cont.Equals("nao")){  aux = false;
  
}


}//fim do loço

  
     
          
           } 

static int buscarPedido(){  
             
                Console.Write(" ");
                Console.Write("Informe o ID do produto que deseja pesquiar: \n=> ");
                int id = Int32.Parse(Console.ReadLine()); 

int aux = pesquisarRegistros(id);
for(int i =0; i < listaPedidos.Count;i++ ){

  if(aux == i){
       Console.WriteLine("\n------------------------------------------------------------\n"+                                  
                                   "# Pedido nº: "+listaPedidos[i].getPedidoID()+"                        \n"+                              
                                   "------------------------------------------------------------\n"+                                
                                   "# Data Emissão: "+listaPedidos[i].getDataEmissao()+"                  \n"+
                                   "# Valor do Produto: "+listaPedidos[i].getValorDoProduto()+"           \n"+
                                   "# Descriçao do Produto: "+listaPedidos[i].getDescricaoDoProduto()+"   \n"+                               
                                   "------------------------------------------------------------\n");  
  return aux;
    } 
}

return -1;
//   Console.WriteLine("\nID: "+element.getPedidoID());
//   Console.WriteLine("Data Emissão: "+element.getDataEmissao());
//   Console.WriteLine("Valor do Produto: "+element.getValorDoProduto());
//   Console.WriteLine("Descriçao do Produto: "+element.getDescricaoDoProduto()+"\n");

  




//http://www.bosontreinamentos.com.br/csharp/listas-em-c-a-classe-generica-list/
               

           } 

static void excluirPedido(){  
consultarPedidos(); 

 Console.Write(" ");
 Console.Write("Informe o ID do produto que deseja excluir: \n=> ");
 int id = Int32.Parse(Console.ReadLine()); 

listaPedidos.RemoveAt(pesquisarRegistros(id)); //remover registro baseado no indice



           
           } 
  

static void alterarPedido(){

int aux = buscarPedido();
bool menu = true;

while (menu){

    Console.Write("\n###############################################################\n"+
                      "#                                                             #\n"+ 
                      "#          Informe qual parâmetro você deseja alterar         #\n"+
                      "#                                                             #\n"+ 
                      "#  1 - Valor do Produto                                       #\n"+   
                      "#  2 - Descricao do Produto                                   #\n"+                       
                      "#  3 - cancelar                                               #\n"+ 
                      "#                                                             #\n"+                 
                      "#                                  Data: "+dateAtual()+"           #\n"+   
                      "#                                                             #\n"+                    
                      "###############################################################\n\n"+

                      "=> "                    
                      
                   ); 

    int caseSwitch = Int32.Parse(Console.ReadLine()); 
      
       switch (caseSwitch){
         case 1:
          Console.WriteLine(" ");
          Console.Write("Informe o novo valor do produto: \n=> ");
          int valorDoProduto = Int32.Parse(Console.ReadLine()); 
          Console.Write(" ");

          //Alterar o valor do produto  
          listaPedidos[aux].setValorDoProduto(valorDoProduto);


         //ValorDoProduto
         break;
         case 2:

          Console.Write("Informe a nova descrição do produto: \n=> ");
          string descricaoDoProduto = Console.ReadLine();
          Console.Write(" ");

          //Alterar o valor a descrição do produto 
          listaPedidos[aux].setDescricaoDoProduto(descricaoDoProduto);
          //Descricao do Produto
         break;                 
         default:
         menu = false;
         break;
       }
    } // Fim do while



}
public static string dateAtual(){
        string Date = DateTime.Now.ToString("dd-MM-yyyy");
        return Date;
    }


public static int createID(){       
           
        Random random = new Random();    
      //int randomnumber = random.Next(1,50);
        int randomnumber = random.Next();
        return randomnumber;                 
    }


//Pesquisar a posição do indice do elemento, mediante ao valor informado (PedidoID)
public static int pesquisarRegistros(int valor){ 

// int contAux = 0; 
int contador = 0;
foreach (Pedidos key in listaPedidos){


if(valor.Equals(key.getPedidoID())){
// Console.WriteLine("Registro encontrado!" +contador);
return contador;
     }//end if
  
contador++;
}//end For


   return -1;

  }// fim da class pesquisarRegistro
       
public static void msgListVazia(){

  Console.Clear();
  Console.WriteLine("\n.\n");
  Console.WriteLine("\n##############################################################\n"+
                      "#                                                            #\n"+     
                      "#                Lista de pedidos vazia!                     #\n"+
                      "#   Por favor, adicione um pedido para visualizar a lista!   #\n"+     
                      "#                                                            #\n"+     
                      "##############################################################\n");
}

  
  }//Fim class

}
