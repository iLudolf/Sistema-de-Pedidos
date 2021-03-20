using AOP02_Paloma.Funcionarios; //Importar Classe Funcionario

namespace AOP02_Paloma.Gerentes{

    //Class Gerente herda ":" da class funcionario 
    public  class Gerente : Funcionario {
    private string senha = "";
    
    public string getSenha(){
        return senha;
    }


    public void setSenha(string pSenha){
        this.senha = pSenha;
    }


    public float calcularDescontoMaior(){
        return 0;
    }

    }// Fim da Class    
}