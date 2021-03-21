using AOP02_Paloma.Funcionarios; //Importar Classe Funcionario

namespace AOP02_Paloma.Estagiarios{

    //Class Gerente herda ":" da class funcionario 
    public  class Estagiario: Funcionario {
    private string senha = "estagiario";
   
    public Estagiario()  : base (Funcionario.nome, Funcionario.matricula ) {

    }
    public string getSenha(){
        return senha;
    }


    public void setSenha(string pSenha){
        this.senha = pSenha;
    }


    public float calcularDescontoMenor(){
        return 0;
    }

    }// Fim da Class    
}