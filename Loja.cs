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
                Console.Clear(); // Limpar console
                Console.Write("\n##############################################################\n"+
                                   "#                                                            #\n"+     
                                   "#                Lista de pedidos vazia!                     #\n"+
                                   "#   Por favor, adicione um pedido para visualizar a lista!   #\n"+     
                                   "#                                                            #\n"+     
                                   "##############################################################\n\n");
    } else {
       consultarPedidos();
    }         break;
          case 2:      
              inserirPedido();         
              break;
         case 3:  
              buscarPedido();            
              break;
         case 4:   
         if(listaPedidos.Count == 0){
               Console.Clear(); // Limpar console
               Console.WriteLine("\n##############################################################\n"+
                                   "#                                                            #\n"+     
                                   "#                Lista de pedidos vazia!                     #\n"+
                                   "#   Por favor, adicione um pedido para visualizar a lista!   #\n"+     
                                   "#                                                            #\n"+     
                                   "##############################################################\n");
          }else {
             excluirPedido(); }                               
              break;
          case 5:  
              Console.WriteLine("Alterar pedido");         
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
 
  Console.WriteLine("\nID: "+element.getPedidoID());
  Console.WriteLine("Data Emissão: "+element.getDataEmissao());
  Console.WriteLine("Valor do Produto: "+element.getValorDoProduto());
  Console.WriteLine("Descriçao do Produto: "+element.getDescricaoDoProduto()+"\n");

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

 listaPedidos.Add(new Pedidos(createID(),DateTime.Now,valorDoProduto,descricaoDoProduto) );

if(cont.Equals("n") || cont.Equals("nao")){  aux = false;
  
}
}//fim do loço

  
     
          
           } 

static void buscarPedido(){  
             
                Console.Write(" ");
                Console.Write("Informe o ID do produto que deseja pesquiar: \n=> ");
                int id = Int32.Parse(Console.ReadLine()); 
           } 

static void excluirPedido(){  
consultarPedidos(); 

 Console.Write(" ");
 Console.Write("Informe o ID do produto que deseja excluir: \n=> ");
 int id = Int32.Parse(Console.ReadLine()); 

listaPedidos.RemoveAt(pesquisarRegistros(id)); //remover registro baseado no indice



           
           } 
  

public static string dateAtual(){
        string Date = DateTime.Now.ToString("dd-MM-yyyy");
        return Date;
    }


public static int createID(){       
           
        Random random = new Random();    
        int randomnumber = random.Next();
        return randomnumber;                 
    }

public static int pesquisarRegistros(int valor){ 

// int contAux = 0; 
int contador = 0;
foreach (Pedidos key in listaPedidos){


if(valor.Equals(key.getPedidoID())){
Console.WriteLine("Registro encontrado!" +contador);
return contador;
     }//end if
  
contador++;
}//end For


   return -1;

  }// fim da class pesquisarRegistro
       

     
    

  
  }//Fim class

}
