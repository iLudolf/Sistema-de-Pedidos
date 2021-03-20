using System;
using System.Collections.Generic; // Importar Collections List 

using AOP02_Paloma.Pedido; // Importar Class Pedido
using AOP02_Paloma.Gerentes; // Importar Class Gerentes
using AOP02_Paloma.Estagiarios; // Importar Class Estagiarios


namespace AOP02_Paloma{
    
class Loja{


  static List<Pedidos> listaPedidos = new List<Pedidos>();     
  static Gerente gerente = new Gerente();
  static Estagiario estagiario = new Estagiario();
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

try{

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
                      "#  6 - Criar usuario                                          #\n"+  
                      "#  7 - Sair                                                   #\n"+ 
                      "#                                                             #\n"+                 
                      "#                                  Data: "+dateAtual()+"           #\n"+   
                      "#                                                             #\n"+                    
                      "###############################################################\n\n"+

                      "=> "                    
                      
                   );    

                   
    int caseSwitch = Int32.Parse(Console.ReadLine()); 

//Estrura do Menu switch
    
      switch (caseSwitch){

          case 1: // consultar Pedidos  

         //Verificar se a lista esta vazia
          if(listaPedidos.Count == 0){
               msgListVazia();
         } else {
               consultarPedidos();
              }break;
          case 2:  //Inserir Pedido

              inserirPedido();         
              break;
         case 3:  //Buscar Pedido

               if(listaPedidos.Count == 0){
               msgListVazia();
          }else {
               buscarPedido(); }          
              break;
         case 4:  //Excluir Pedido

         if(listaPedidos.Count == 0){
               msgListVazia();
          }else {
             excluirPedido(); }                               
              break;

          case 5:   //Alterar Pedido
               if(listaPedidos.Count == 0){
               msgListVazia();
          }else {
             alterarPedido(); }   
          break;
           case 6:   //Criar usuario
         
                           
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

   
     
  
   }catch (Exception e){
       Console.WriteLine(e.Message);
      }  //Catch  

}   //Fim do while

}// Fim Main
static void consultarPedidos(){  
  
  foreach (Pedidos element in listaPedidos){
 
               Console.WriteLine("\n------------------------------------------------------------\n"+                                  
                                   "# Pedido nº: "+element.getPedidoID()+"                        \n"+                              
                                   "------------------------------------------------------------\n"+ 
                                   "# Nome: "+element.getNome()+"                                \n"+                               
                                   "# Data Emissão: "+element.getDataEmissao()+"                  \n"+
                                   "# Valor do Produto: "+element.getValorDoProduto()+"           \n"+
                                   "# Descriçao do Produto: "+element.getDescricaoDoProduto()+"   \n"+                               
                                   "------------------------------------------------------------\n");     



    }
    
           }  //Fim do metodo Consultar Pedidos

static void inserirPedido(){  
  
bool aux = true; 

//Laço para ir adicionando valores a List Collections
 while(aux){

 
//Trativa de erro, caso o usuario infome algum valor incorreto.
 try{
  Console.WriteLine(" ");
  Console.Write("Informe o nome do produto: \n=> "); 
  string nomeProd = Console.ReadLine(); 

 Console.WriteLine(" ");
 Console.Write("Informe o valor do produto: \n=> ");
 int valorDoProduto = Int32.Parse(Console.ReadLine()); 
 Console.Write(" ");

 Console.WriteLine(" ");
 Console.Write("Informe a descrição do produto: \n=> ");
 string descricaoDoProduto = Console.ReadLine();
 Console.Write(" ");
 
 Console.WriteLine(" ");
 Console.Write("\nDeseja adicionar mais pedidos?\n");
 Console.Write("Digite: [S] Sim ou [N] Não \n\n => ");
 string cont = Console.ReadLine();
 Console.Write(" ");

 //Adicionar valores na lista: Criando o Objeto Pedidos com os dados informados
listaPedidos.Add(new Pedidos(nomeProd,createID(),DateTime.Now,valorDoProduto,descricaoDoProduto) );

// Chamar o metodo para exibir os pedidos 
consultarPedidos(); 

if(cont.Equals("n") || cont.Equals("nao")){  aux = false;
  
}

}catch (Exception e){
  Console.Clear();
  Console.WriteLine(e.Message);
}



}//fim do loço

  
     
          
           } 

static int buscarPedido(){  

//Tratativa de erro             
try{
  
 Console.Write(" ");
 Console.Write("Informe o ID do produto que deseja pesquisar: \n=> ");
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

}
catch (Exception e){
   Console.Clear();
   Console.WriteLine(e.Message);
}// FIm do Tray



return -1;
//   Console.WriteLine("\nID: "+element.getPedidoID());
//   Console.WriteLine("Data Emissão: "+element.getDataEmissao());
//   Console.WriteLine("Valor do Produto: "+element.getValorDoProduto());
//   Console.WriteLine("Descriçao do Produto: "+element.getDescricaoDoProduto()+"\n");
      

           } 

static void excluirPedido(){  
consultarPedidos(); 

//Tratativa de erro 
try{
  
 Console.Write(" ");
 Console.Write("Informe o ID do produto que deseja excluir: \n=> ");
 int id = Int32.Parse(Console.ReadLine()); 

listaPedidos.RemoveAt(pesquisarRegistros(id)); //remover registro baseado no indice



  }catch (Exception e){
      Console.Clear();
      //Caso ocorre alguém erro, informe a mensagem do erro.
      Console.WriteLine(e.Message);
      
  }        
           } // Fim do metodo
  

static void alterarPedido(){

//Trativa de erro
try{
  
int aux = buscarPedido();
bool menu = true;

while (menu){

    Console.Write("\n###############################################################\n"+
                      "#                                                             #\n"+ 
                      "#          Informe qual parâmetro você deseja alterar         #\n"+
                      "#                                                             #\n"+ 
                      "#  1 - Nome do Produto                                        #\n"+
                      "#  2 - Valor do Produto                                       #\n"+   
                      "#  3 - Descricao do Produto                                   #\n"+                       
                      "#  4 - Voltar                                                 #\n"+ 
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
          Console.Write("Informe o novo nome do produto: "+listaPedidos[aux].getNome()+"\n=> ");
          string nomeDoProduto = Console.ReadLine(); 
          Console.Write(" ");

          //Alterar o valor do produto  
          listaPedidos[aux].setnome(nomeDoProduto);
          break;

         case 2:      
          Console.WriteLine(" ");
          Console.Write("Informe o novo valor do produto "+listaPedidos[aux].getNome()+": \n=> ");
          int valorDoProduto = Int32.Parse(Console.ReadLine()); 
          Console.Write(" ");

          //Alterar o valor do produto  
          listaPedidos[aux].setValorDoProduto(valorDoProduto);   

         //ValorDoProduto
         break;
         case 3: //Descricao do Produto

          Console.Write("Informe a nova descrição do produto "+listaPedidos[aux].getNome()+": \n=> ");
          string descricaoDoProduto = Console.ReadLine();
          Console.Write(" ");

          //Alterar o valor a descrição do produto 
          listaPedidos[aux].setDescricaoDoProduto(descricaoDoProduto);         
         break;      

         default: // Sair
         menu = false;
         break;
       }
    } // Fim do while

}
catch (Exception e){
   Console.Clear();
   Console.WriteLine(e.Message);
} // Fim do try


} // Fim da Class
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
